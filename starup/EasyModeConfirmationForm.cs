using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace starup
{
    public partial class EasyModeConfirmationForm : Form
    {
        private Shrinker easyModeConfirmationAni;  // Shrinker class instance
        private Form1 form1;

        public EasyModeConfirmationForm(Form1 parentForm)
        {
            InitializeComponent();
            easyModeConfirmationAni = new Shrinker();  // Initialize Shrinker without passing buttons

            // Attach event handlers for MouseDown and MouseUp for both Yes and No buttons
            AttachButtonEvents(Yes);
            AttachButtonEvents(No);

            form1 = parentForm;
        }

        // Helper method to attach MouseDown and MouseUp event handlers to a button
        private void AttachButtonEvents(Button button)
        {
            button.MouseDown += (sender, e) => ResizeButton(sender as Button, -20, -10);  // Shrink button
            button.MouseUp += (sender, e) => ResizeButton(sender as Button, 20, 10);  // Restore button size
        }

        // Helper method to resize buttons
        private void ResizeButton(Button button, int widthChange, int heightChange)
        {
            if (button != null)
            {
                easyModeConfirmationAni.ResizeButton(button, widthChange, heightChange);  // Resize button
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a GraphicsPath to define the rounded corners
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 60;
                path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
                path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90); // Top-right corner
                path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90); // Bottom-right corner
                path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90); // Bottom-left corner
                path.CloseFigure();

                this.Region = new Region(path);

                // Custom border
                using (Pen borderPen = new Pen(Color.White, 8))
                {
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;

            this.Hide();

            // Hide Form1 immediately
            if (form1 != null)
            {
                form1.Hide();  // Hide Form1
                form1.Close(); // Close Form1
                form1.Dispose(); // Dispose Form1 to clean up resources
            }

            // Create and set up LoadingLogic
            LoadingLogic loadingLogic = new LoadingLogic();
            loadingLogic.SetPreviousChoice(DialogResult.Yes); // Set the choice based on the user's input

            // Create and show the LoadingForm, passing the LoadingLogic instance
            LoadingForm loadingForm = new LoadingForm(loadingLogic);
            loadingForm.ShowDialog();
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void EasyModeConfirmationForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            // Set up button positions
            label1.Left = (this.Width - label1.Width) / 2;
            label2.Left = (this.Width - label2.Width) / 2;

            int paddingTop = 40; // Space from the edges of the form
            int spacing = 40; // Space between the buttons

            // Calculate starting position for the first button
            Yes.Left = (this.ClientSize.Width - (Yes.Width + spacing + No.Width)) / 2;
            Yes.Top = this.ClientSize.Height - Yes.Height - paddingTop;

            // Position the second button
            No.Left = Yes.Right + spacing;
            No.Top = Yes.Top;
        }
    }
}
