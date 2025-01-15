using System.Drawing;
using System.IO;

namespace starup
{
    public partial class Form1 : Form
    {
        private PlayBtnsAni playBtnsAni;
        private LayoutManager layoutManager;
        private FormControlButtons formControlButtons;

        // Constructor
        public Form1()
        {
            InitializeComponent();

            playBtnsAni = new PlayBtnsAni(logo, play, btnEasy, btnHard);

            layoutManager = new LayoutManager(this);

            formControlButtons = new FormControlButtons(
               this,
               Properties.Resources.minimize, // Use the resource directly
               Properties.Resources.close // Use the resource directly
           );
        }


        // Load event handler
        private void Form1_Load(object sender, EventArgs e)
        {
            layoutManager.CenterControl(logo, -90); // Logo s vertikálním posunem
            layoutManager.PositionBelow(play, logo); // Play pod logem
            layoutManager.CenterControl(btnEasy, -50); // Easy tlaèítko s vertikálním posunem
            layoutManager.CenterControl(btnHard, 250); // Hard tlaèítko s vertikálním posunem
        }

        // Play button click event handler
        private void play_Click(object sender, EventArgs e)
        {
            playBtnsAni.StartAnimation();
            playBtnsAni.StartFadeOut();
        }

        // Easy button click event handler
        private void btnEasy_Click(object sender, EventArgs e)
        {
            EasyModeConfirmationForm confirmationForm = new EasyModeConfirmationForm(this);
            DialogResult result = confirmationForm.ShowDialog();
        }

        // Hard button click event handler
        private void btnHard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP");
        }
    }
}
