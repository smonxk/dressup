using System;
using System.Windows.Forms;

namespace starup
{
    public class LoadingLogic
    {
        public DialogResult PreviousChoice { get; private set; }

        // Method to set the previous choice, this can be 'Yes' or 'No' or any custom result
        public void SetPreviousChoice(DialogResult result)
        {
            PreviousChoice = result;
        }

        // Determine which form to show after the loading screen
        public Form GetNextFormAfterLoading()
        {
            switch (PreviousChoice)
            {
                case DialogResult.Yes:
                    return new ChooseCharForm(); // Now works because ChooseChar inherits from Form
                default:
                    return null;
            }
        }
    }
}
