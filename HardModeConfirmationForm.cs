using System;
using System.Drawing;
using System.Windows.Forms;

namespace starup
{
    public partial class HardModeConfirmationForm : Form
    {
        private readonly Shrinker shrinker;
        private readonly LayoutManager layoutManager;

        public HardModeConfirmationForm(Form1 parentForm)
        {
            InitializeComponent();
            shrinker = new Shrinker();
            layoutManager = new LayoutManager(this);

            okHardBtn.MouseDown += (sender, e) => shrinker.ResizeControl(okHardBtn, -20, -10);
            okHardBtn.MouseUp += (sender, e) => shrinker.ResizeControl(okHardBtn, 20, 10);
            layoutManager.CenterControl(panelGameInfo);
        }

        private void HardModeConfirmationForm_Load(object sender, EventArgs e)
        {
            PopulateInfoTextBox();
        }

        //info about game for users
        private void PopulateInfoTextBox()
        {
            AddTextToInfoBox("About game", 18, FontStyle.Bold);
            AddTextToInfoBox("\nThis project contains PNGs downloaded on the internet.\n" +
                             "I did not create them and I credit the owners with full respect.\n" +
                             "Thank you for understanding.", 12, FontStyle.Bold);

            AddTextToInfoBox("\n\nHow to play?", 18, FontStyle.Bold);
            AddTextToInfoBox("\nClick Ok and then the upper button :-)", 12, FontStyle.Bold);

            AddTextToInfoBox("\n\nFor my professor", 18, FontStyle.Bold);
            AddTextToInfoBox("\nThis game was supposed to have two play modes. There is still some evidence left of that, such as the Dialogues file or the fact that this form is called HardModeConfirmationForm.\n" +
                             "If you are reading this text, it means I didn’t have time to finish the hard mode I aspired for.\n" +
                             "I do sincerely apologize for this shortcoming of mine.", 12, FontStyle.Bold);
        }

        private void AddTextToInfoBox(string text, int fontSize, FontStyle style)
        {
            infoTextBox.SelectionFont = new Font("Arial", fontSize, style);
            infoTextBox.SelectionAlignment = HorizontalAlignment.Center;
            infoTextBox.AppendText(text);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                base.OnPaint(e);
                Rounder.RoundPanel(panelGameInfo, 60, Color.White);
                Rounder.RoundForm(this, 60, Color.White, 8, e);
            }
            catch (Exception ex)
            {
                // notices or handles any drawing-related errors
                Console.WriteLine($"Painting error: {ex.Message}");
            }
        }

        private void OkHardBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
