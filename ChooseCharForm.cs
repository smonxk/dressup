using System;
using System.Windows.Forms;
using System.Threading.Tasks; // For Task.Delay

namespace starup
{
    public partial class ChooseCharForm : Form
    {
        private Fader charInerysAni;
        private Fader charLorainaAni;

        private Fader playInerysAni;
        private Fader playLorainaAni;

        private Fader infoInerysAni;
        private Fader infoLorainaAni;

        private FormControlButtons formControlButtons;
        private InfoCharLogic infoCharLogic;
        private LoadingLogic loadingLogic;
        private Shrinker shrinker;

        public ChooseCharForm()
        {
            InitializeComponent();
            formControlButtons = new FormControlButtons(
                this,
                Properties.Resources.minimize,
                Properties.Resources.close
            );
            infoCharLogic = new InfoCharLogic();
            loadingLogic = new LoadingLogic();
            shrinker = new Shrinker();

            // attaches the same MouseDown and MouseUp handlers to all relevant PictureBox controls
            AttachResizeEventHandlers();
        }

        private void AttachResizeEventHandlers()
        {
            foreach (var pictureBox in new[] {  infoInerys, infoLoraina, playInerys, playLoraina })
            {
                pictureBox.MouseDown += InfoPictureBox_MouseDown;
                pictureBox.MouseUp += InfoPictureBox_MouseUp;
            }
        }

        private void InfoPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            var pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                shrinker.ResizeControl(pictureBox, -20, -10);
            }
        }

        private void InfoPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            var pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                shrinker.ResizeControl(pictureBox, 20, 10);
            }
        }

        private async void ChooseChar_Load(object sender, EventArgs e)
        {
            
            InitializeFaders();

            // to ensure no flickering when the form loads
            await Task.Delay(100);

            StartFadeInAnimations();
        }

        private void InitializeFaders()
        {
            //  all Fader objects for characters, play, and info PictureBoxes
            charInerysAni = new Fader(charInerys);
            charLorainaAni = new Fader(charLoraina);

            playInerysAni = new Fader(playInerys);
            playLorainaAni = new Fader(playLoraina);

            infoInerysAni = new Fader(infoInerys);
            infoLorainaAni = new Fader(infoLoraina);
        }

        private void StartFadeInAnimations()
        {
            var faders = new[] { charInerysAni, charLorainaAni, playInerysAni, playLorainaAni, infoInerysAni, infoLorainaAni };

            foreach (var fader in faders)
            {
                fader.StartFadeIn();
            }
        }

        private void InfoPictureBox_Click(object sender, EventArgs e)
        {
            string? characterName = (sender as PictureBox)?.Tag.ToString();  
            if (!string.IsNullOrEmpty(characterName))
            {
                ShowCharacterInfo(characterName);
            }
        }

        private void ShowCharacterInfo(string characterName)
        {

            string description = infoCharLogic.GetCharacterDescription(characterName);

            // opens infocharform
            InfoCharForm infoForm = new InfoCharForm(characterName, description);
            infoForm.ShowDialog();
        }

        private void PlayPictureBox_Click(object sender, EventArgs e)
        {
            string? characterName = (sender as PictureBox)?.Tag.ToString();  // clicked pbox provides tag (character name)
            if (!string.IsNullOrEmpty(characterName))
            {
                loadingLogic.SetCharacterChoice(characterName);  
                ShowLoadingScreen();  
            }
        }

        private void ShowLoadingScreen()
        {
            this.Hide();  // hides the ChooseCharForm 

            LoadingForm loadingForm = new LoadingForm(loadingLogic);
            loadingForm.ShowDialog();  // Show the loading screen

            Form nextForm = loadingLogic.GetNextFormAfterLoading();
            if (nextForm != null)
            {
                nextForm.ShowDialog(this);
            }

            this.Dispose();  // disposes of this form after getting dressing form
        }
    }
}
