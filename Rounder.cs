using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace starup
{
    public static class Rounder
    {
        public static void RoundForm(Form form, int radius, Color borderColor, int borderThickness, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                // defines rounded corners for a form. following methods do si
                path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
                path.AddArc(form.Width - radius - 1, 0, radius, radius, 270, 90); // Top-right corner
                path.AddArc(form.Width - radius - 1, form.Height - radius - 1, radius, radius, 0, 90); // Bottom-right corner
                path.AddArc(0, form.Height - radius - 1, radius, radius, 90, 90); // Bottom-left corner
                path.CloseFigure();

                
                form.Region = new Region(path);

                // draws the border
                using (Pen borderPen = new Pen(borderColor, borderThickness))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        public static void RoundPanel(Panel panel, int radius, Color borderColor = default, int borderThickness = 0)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int offset = 1;
                path.AddArc(offset, offset, radius, radius, 180, 90);
                path.AddArc(panel.Width - radius - offset, offset, radius, radius, 270, 90);
                path.AddArc(panel.Width - radius - offset, panel.Height - radius - offset, radius, radius, 0, 90);
                path.AddArc(offset, panel.Height - radius - offset, radius, radius, 90, 90);
                path.CloseFigure();

                panel.Region = new Region(path);

                if (borderThickness > 0) //border not mandatory
                {
                    using (Graphics g = panel.CreateGraphics())
                    {
                        using (Pen borderPen = new Pen(borderColor, borderThickness))
                        {
                            g.DrawPath(borderPen, path);
                        }
                    }
                }
            }
        }

        public static void RoundLabel(Label label, int radius, Color borderColor, int borderThickness)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int offset = 1;
                path.AddArc(offset, offset, radius, radius, 180, 90);
                path.AddArc(label.Width - radius - offset, offset, radius, radius, 270, 90);
                path.AddArc(label.Width - radius - offset, label.Height - radius - offset, radius, radius, 0, 90);
                path.AddArc(offset, label.Height - radius - offset, radius, radius, 90, 90);
                path.CloseFigure();

                label.Region = new Region(path);

                if (borderThickness > 0)
                {
                    using (Graphics g = label.CreateGraphics())
                    {
                        using (Pen borderPen = new Pen(borderColor, borderThickness))
                        {
                            g.DrawPath(borderPen, path);
                        }
                    }
                }
            }
        }

        public static void RoundPictureBox(PictureBox pictureBox, int radius, Color borderColor = default, int borderThickness = 0)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(pictureBox.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(pictureBox.Width - radius - 1, pictureBox.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, pictureBox.Height - radius - 1, radius, radius, 90, 90);
                path.CloseFigure();

                pictureBox.Region = new Region(path);

              
                if (borderThickness > 0)
                {
                    using (Graphics g = pictureBox.CreateGraphics())
                    {
                        using (Pen borderPen = new Pen(borderColor, borderThickness))
                        {
                            g.DrawPath(borderPen, path);
                        }
                    }
                }
            }
        }
    }
}
