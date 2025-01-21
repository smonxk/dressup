namespace starup
{

    public class PanelVisibilityManager
    {
        public void ShowPanelBasedOnTag(Control form, string tag) //it is used in design forms (návrh)
        {
            foreach (Control control in form.Controls)
            {
                if (control is Panel panel && panel != form.Controls["panel"] && panel != form.Controls["panelSections"])
                {
                    panel.Visible = panel.Tag?.ToString() == tag;
                }
            }
        }
    }
}

