using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace starup
{
    public partial class InfoCharForm : Form
    {
        private Shrinker shrinker;

        // Constructor for InfoCharForm
        public InfoCharForm(string characterName, string description)
        {
            InitializeComponent();

            // Initialize the shrinker object
            shrinker = new Shrinker();

            // Display the character name and description
            labelName.Text = characterName;
            charDescription.Text = description;

            // aAttach events for the OK button
            okBtn.MouseDown += OkMouseDown;
            okBtn.MouseUp += OkMouseUp;

            charDescription.Paint += CharDescription_Paint;

        }

        // Event to shrink the OK button when pressed
        private void OkMouseDown(object sender, MouseEventArgs e)
        {
            shrinker.ResizePictureBox(okBtn, -20, -10);
        }

        // Event to restore the OK button size when released
        private void OkMouseUp(object sender, MouseEventArgs e)
        {
            shrinker.ResizePictureBox(okBtn, 20, 10);
        }

        private void CharDescription_Paint(object sender, PaintEventArgs e)
        {
            // Get the label for painting
            Label label = (Label)sender;

            int radius = 20; // Corner radius
            int borderWidth = 2; 

            // Create rounded rectangle path
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
                path.AddArc(label.Width - radius - 1, 0, radius, radius, 270, 90); // Top-right corner
                path.AddArc(label.Width - radius - 1, label.Height - radius - 1, radius, radius, 0, 90); // Bottom-right corner
                path.AddArc(0, label.Height - radius - 1, radius, radius, 90, 90); // Bottom-left corner
                path.CloseFigure();


                // Optional: Drawing a border with the specified color
                using (Pen borderPen = new Pen(Color.FromArgb(184, 50, 134), borderWidth)) // Border color same as requested
                {
                    e.Graphics.DrawPath(borderPen, path); // Draw the border
                }
            }
        }

        // Custom painting for rounded Form borders
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 60;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);

                using (Pen borderPen = new Pen(Color.FromArgb(184, 50, 134), 8))
                {
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        // Close the form when the OK button is clicked
        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
