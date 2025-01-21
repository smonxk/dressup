using System.Drawing;
using System.IO;

namespace starup
{
    public partial class Form1 : Form
    {
        // declaratons of instances of classes we will be using!
        private PlayBtnsAni playBtnsAni;
        private LayoutManager layoutManager;
        private FormControlButtons formControlButtons;

        //constructor :
        public Form1()
        {
            InitializeComponent();

            // initiliazes animation for the buttons 
            playBtnsAni = new PlayBtnsAni(logo, play, btnEasy, btnHard);

            // initializes the layout manager, so that we can manage our layout :)
            layoutManager = new LayoutManager(this);

            // initializes control buttons
            formControlButtons = new FormControlButtons(
               this,
               Properties.Resources.minimize, // uses minimize icon from resources
               Properties.Resources.close // uses close icon from resources
           );
        }

        // positioning layout with the help of layout manager 
        private void Form1_Load(object sender, EventArgs e)
        {
        
            layoutManager.CenterControl(logo, -90);
            layoutManager.PositionBelow(play, logo);
            layoutManager.CenterControl(btnEasy, -50);
            layoutManager.CenterControl(btnHard, 250);
        }

        // clicking play starts the animation
        private void Play_Click(object sender, EventArgs e)
        {
            playBtnsAni.StartAnimation();  
            playBtnsAni.StartFadeOut();   
        }

        // opens the confirmation form for easy mode
        private void BtnEasy_Click(object sender, EventArgs e)
        {
            EasyModeConfirmationForm confirmationForm = new EasyModeConfirmationForm(this); //confirming easy mode selection can close form 1
            DialogResult result = confirmationForm.ShowDialog(); //show the dialog and save the result
        }

        private void BtnHard_Click(object sender, EventArgs e)
        {
            HardModeConfirmationForm confirmationForm = new HardModeConfirmationForm(this);
            DialogResult result = confirmationForm.ShowDialog(); // shows the dialog and capture the result - in this version not hardmode
        }
    }
}
