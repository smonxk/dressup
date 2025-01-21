using System.Windows.Forms;

namespace starup
{
    public class LayoutManager
    {
        private Form form;

        public LayoutManager(Form form)
        {
            this.form = form;
        }

        // centering horizontally with a vertical offset 
        public void CenterControl(Control control, int verticalOffset = 0)
        {
            control.Left = (form.ClientSize.Width - control.Width) / 2;
            control.Top = (form.ClientSize.Height - control.Height) / 2 + verticalOffset;
        }

        // puts one control under other with a space in between
        public void PositionBelow(Control control, Control anchor, int verticalSpacing = 0)
        {
            control.Left = (form.ClientSize.Width - control.Width) / 2;
            control.Top = anchor.Bottom + verticalSpacing;
        }
        
        public void ControlPosition(Control control, int horizontalOffset = 0, int verticalOffset = 0)
        {
            control.Left = (form.ClientSize.Width - control.Width) / 2 + horizontalOffset;
            control.Top = (form.ClientSize.Height - control.Height) / 2 + verticalOffset;
        }
    }
}
