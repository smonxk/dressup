using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace starup
{
    public class CustomScrollbar : Control
    {
        private readonly ScrollableControl targetControl;
        private int scrollOffset; // scrollbar position
        private bool isDragging;
        private Point lastMousePosition;

        private readonly Color barColor;
        private readonly int barRadius;
        private const int BarHeight = 100; // height for the scrollbar

        public CustomScrollbar(ScrollableControl targetControl, Color barColor, int barRadius = 10)
        {
            this.targetControl = targetControl ?? throw new ArgumentNullException(nameof(targetControl));
            this.barColor = barColor;
            this.barRadius = barRadius;

            InitializeScrollbar();
        }

        private void InitializeScrollbar()
        {
            this.Width = 12; //  scrollbar width
            this.DoubleBuffered = true;

            targetControl.AutoScroll = true;
            targetControl.VerticalScroll.Visible = false; 
            targetControl.HorizontalScroll.Visible = false;

            // Attach events
            targetControl.MouseWheel += HandleMouseWheel;
            targetControl.SizeChanged += (_, _) => UpdateScrollbar();
            targetControl.Scroll += (_, _) => UpdateScrollbar();

            this.MouseDown += StartDragging;
            this.MouseMove += DragScrollbar;
            this.MouseUp += StopDragging;
            this.Paint += DrawScrollbar;

            UpdateScrollbar();
        }

        private void HandleMouseWheel(object sender, MouseEventArgs e)
        {
            ScrollBy(e.Delta > 0 ? -20 : 20); // adjusts scroll amount
        }

        private void StartDragging(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void DragScrollbar(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int delta = e.Y - lastMousePosition.Y;
                ScrollBy(delta);
                lastMousePosition = e.Location;
            }
        }

        private void StopDragging(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void DrawScrollbar(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.None;

            using var path = CreateScrollbarPath();
            using var brush = new SolidBrush(barColor);
            e.Graphics.FillPath(brush, path);
        }

        private GraphicsPath CreateScrollbarPath()
        {
            var path = new GraphicsPath();

            path.AddArc(0, scrollOffset, barRadius, barRadius, 180, 90);
            path.AddArc(this.Width - barRadius - 1, scrollOffset, barRadius, barRadius, 270, 90);
            path.AddArc(this.Width - barRadius - 1, scrollOffset + BarHeight - barRadius - 1, barRadius, barRadius, 0, 90);
            path.AddArc(0, scrollOffset + BarHeight - barRadius - 1, barRadius, barRadius, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void ScrollBy(int delta)
        {
            if (targetControl == null) return;

            int newValue = Math.Max(targetControl.VerticalScroll.Value + delta, targetControl.VerticalScroll.Minimum);
            targetControl.VerticalScroll.Value = Math.Min(newValue, targetControl.VerticalScroll.Maximum);
            targetControl.PerformLayout();

            UpdateScrollbar();
        }

        private void UpdateScrollbar()
        {
            if (targetControl == null) return;

            this.Height = targetControl.Height;

            int totalScrollableHeight = targetControl.VerticalScroll.Maximum - targetControl.VerticalScroll.Minimum;
            if (totalScrollableHeight <= 0) return;

            float scrollRatio = (float)targetControl.VerticalScroll.Value / totalScrollableHeight;
            scrollOffset = (int)(scrollRatio * (this.Height - BarHeight));

            Invalidate(); 
        }

        public void AttachToParent(Control parent)
        {
            parent.Controls.Add(this);
            this.BringToFront();
            PositionScrollbar();
        }

        private void PositionScrollbar()
        {
            this.Location = new Point(targetControl.Right - this.Width - 2, targetControl.Top);
            UpdateScrollbar();
        }
    }
}
