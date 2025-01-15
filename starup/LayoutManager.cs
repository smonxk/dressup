using System.Windows.Forms;

namespace starup
{
    // Třída odpovědná za správu rozvržení prvků na formuláři
    public class LayoutManager
    {
        private Form form;

        public LayoutManager(Form form)
        {
            this.form = form;
        }

        // Metoda pro zarovnání prvku horizontálně a vertikálně s volitelným posunem
        public void CenterControl(Control control, int verticalOffset = 0)
        {
            control.Left = (form.ClientSize.Width - control.Width) / 2;
            control.Top = (form.ClientSize.Height - control.Height) / 2 + verticalOffset;
        }

        // Metoda pro zarovnání prvku pod jiný prvek s mezery
        public void PositionBelow(Control control, Control anchor, int verticalSpacing = 0)
        {
            control.Left = (form.ClientSize.Width - control.Width) / 2;
            control.Top = anchor.Bottom + verticalSpacing;
        }
    }
}
