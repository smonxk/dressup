using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace starup
{
    public class LoadingLogic
    {
        public DialogResult PreviousChoice { get; private set; } // stores the previous choice 
        public string CharacterChoice { get; private set; }     // stores the character choice as a string 

        public void SetPreviousChoice(DialogResult result)
        {
            PreviousChoice = result;  // set the previous choice when a decision is made (e.g., Yes to playing)
        }

        // method to set the character choice (Avalon, Tygistae, etc.)
        public void SetCharacterChoice(string characterName)
        {
            CharacterChoice = characterName;  // set the character name when chosen
        }

        public void ShowLoadingScreen(Form currentForm)
        {
            
            currentForm.Hide();


            LoadingForm loadingForm = new LoadingForm(this);
            loadingForm.Show(); 

            // wait for a while (simulating loading but it is not really)
            Task.Delay(3500).ContinueWith(t =>
            {
                
                ShowNextForm(currentForm);

                // closes the loading form after the transition
                loadingForm.Invoke((Action)(() =>
                {
                    loadingForm.Close(); 
                }));
            });
        }

        // determines which form to show after the loading screen
        public void ShowNextForm(Form currentForm)
        {
            
            Form nextForm = GetNextFormAfterLoading();

            
            if (nextForm != null)
            {
                nextForm.ShowDialog(); 
            }

            // dispose the current form after the transition
            currentForm.Dispose();
        }

        // which form to show based on previous choice
        public Form GetNextFormAfterLoading()
        {
            switch (PreviousChoice)
            {
                case DialogResult.Yes:
                    return new ChooseCharForm();
                default:
                    return GetCharacterDressingForm();
            }
        }

        
        private Form GetCharacterDressingForm()
        {
            switch (CharacterChoice)
            {
                case "Avalon":
                    return new DressingAvalonForm();  //wip
                case "Tygistae":
                    return new DressingTygistaeForm();  // wip
                case "Inerys":
                    return new DressingInerysForm();  
                case "Loraina":
                    return new DressingLorainaForm(); 
                default:
                    return null;  // if no valid character was chosen
            }
        }
    }
}
