
using System.Drawing;
using System.Windows.Forms;

namespace starup
{
    public class Shrinker
    {

        public Shrinker() { }
        public void ResizeControl(Control control, int widthChange, int heightChange)
        {
            if (control != null)
            {
                // gets the current size and position of the control
                int originalWidth = control.Width;
                int originalHeight = control.Height;
                int originalX = control.Left;
                int originalY = control.Top;

                // calculates new size (when clicked)
                int newWidth = originalWidth + widthChange;
                int newHeight = originalHeight + heightChange;

                // the new size cant be negative : 
                newWidth = Math.Max(newWidth, 1);
                newHeight = Math.Max(newHeight, 1); 

                // calculates the change in size and divides it by two to adjust the position the button should get smaller to the direction of its centre
                int widthDiff = (newWidth - originalWidth) / 2;
                int heightDiff = (newHeight - originalHeight) / 2;

                
                control.Left = originalX - widthDiff;
                control.Top = originalY - heightDiff;

                // applies size
                control.Size = new Size(newWidth, newHeight);
            }
        }
    }
}
