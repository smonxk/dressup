using System;
using System.Windows.Forms;
using System.Threading.Tasks; // For Task.Delay

namespace starup
{
    public partial class ChooseCharForm : Form
    {
        private Fader charInerysAni;
        private Fader charLorainaAni;
        private Fader charAvalonAni;
        private Fader charTygistaeAni;

        private Fader playTygistaeAni;
        private Fader playInerysAni;
        private Fader playAvalonAni;
        private Fader playLorainaAni;

        private Fader infoTygistaeAni;
        private Fader infoInerysAni;
        private Fader infoAvalonAni;
        private Fader infoLorainaAni;

        private FormControlButtons formControlButtons;

        private InfoCharLogic infoCharLogic;

        public ChooseCharForm()
        {
            InitializeComponent();

            // Initialize form control buttons for minimize and close functionality
            formControlButtons = new FormControlButtons(
                this,
                Properties.Resources.minimize,
                Properties.Resources.close
            );

            // Initialize InfoCharLogic to load character data
            infoCharLogic = new InfoCharLogic();
        }

        private async void ChooseChar_Load(object sender, EventArgs e)
        {
            // Initialize the Fader objects for animations
            charInerysAni = new Fader(charInerys);
            charLorainaAni = new Fader(charLoraina);
            charAvalonAni = new Fader(charAvalon);
            charTygistaeAni = new Fader(charTygistae);

            playTygistaeAni = new Fader(playTygistae);
            playInerysAni = new Fader(playInerys);
            playAvalonAni = new Fader(playAvalon);
            playLorainaAni = new Fader(playLoraina);

            infoTygistaeAni = new Fader(infoTygistae);
            infoInerysAni = new Fader(infoInerys);
            infoAvalonAni = new Fader(infoAvalon);
            infoLorainaAni = new Fader(infoLoraina);

            // Add a small delay to ensure no flickering when the form loads
            await Task.Delay(100);

            // Start fade-in animation for all elements
            charInerysAni.StartFadeIn();
            charLorainaAni.StartFadeIn();
            charAvalonAni.StartFadeIn();
            charTygistaeAni.StartFadeIn();

            playTygistaeAni.StartFadeIn();
            playInerysAni.StartFadeIn();
            playAvalonAni.StartFadeIn();
            playLorainaAni.StartFadeIn();

            infoTygistaeAni.StartFadeIn();
            infoInerysAni.StartFadeIn();
            infoAvalonAni.StartFadeIn();
            infoLorainaAni.StartFadeIn();
        }

        // Event handlers for the "Info" buttons
        private void infoAvalon_Click(object sender, EventArgs e)
        {
            ShowCharacterInfo("Avalon");
        }

        private void infoTygistae_Click(object sender, EventArgs e)
        {
            ShowCharacterInfo("Tygistae");
        }

        private void infoInerys_Click(object sender, EventArgs e)
        {
            ShowCharacterInfo("Inerys");
        }

        private void infoLoraina_Click(object sender, EventArgs e)
        {
            ShowCharacterInfo("Lorainel");
        }

        private void ShowCharacterInfo(string characterName)
        {
            // Get the character description
            string description = infoCharLogic.GetCharacterDescription(characterName);

            // Open the InfoCharForm with the character name and description
            InfoCharForm infoForm = new InfoCharForm(characterName, description);
            infoForm.ShowDialog();
        }
    }
}
