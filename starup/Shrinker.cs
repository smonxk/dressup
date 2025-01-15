using System.Drawing;
using System.Windows.Forms;

namespace starup
{
    public class Shrinker
    {
        // No constructor needed, just a method to resize any control
        public Shrinker() { }

        // Method to resize a Button (used in your form)
        public void ResizeButton(Button button, int widthChange, int heightChange)
        {
            if (button != null)
            {
                button.Size = new Size(button.Width + widthChange, button.Height + heightChange);
            }
        }

        // Method to resize a PictureBox
        public void ResizePictureBox(PictureBox pictureBox, int widthChange, int heightChange)
        {
            if (pictureBox != null)
            {
                pictureBox.Size = new Size(pictureBox.Width + widthChange, pictureBox.Height + heightChange);
            }
        }
    }
}
