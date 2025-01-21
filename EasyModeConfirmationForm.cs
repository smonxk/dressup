using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace starup
{
    public partial class EasyModeConfirmationForm : Form
    {
        private readonly Shrinker easyModeConfirmationAni;  
        private readonly Form1 form1;

        public EasyModeConfirmationForm(Form1 parentForm)
        {
            InitializeComponent();
            easyModeConfirmationAni = new Shrinker();  

            AttachButtonEvents(Yes);
            AttachButtonEvents(No);

            form1 = parentForm;
        }

        // helper method to attach mouseDown and mouseUp event handlers to a button
        private void AttachButtonEvents(Button button)
        {
            button.MouseDown += (sender, e) => ResizeButton(sender as Button, -20, -10);  
            button.MouseUp += (sender, e) => ResizeButton(sender as Button, 20, 10);  
        }

        // Helper method to resize buttons
        private void ResizeButton(Button button, int widthChange, int heightChange)
        {
            if (button != null)
            { 
                easyModeConfirmationAni.ResizeControl(button, widthChange, heightChange);  
            }
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;

            this.Hide();

            // ´hides Form1 
            if (form1 != null)
            {
                form1.Hide();  
                form1.Close(); 
                form1.Dispose(); 
            }

            // creates and set up LoadingLogic
            LoadingLogic loadingLogic = new LoadingLogic();
            loadingLogic.SetPreviousChoice(DialogResult.Yes); // sets the choice based on the user's input

            // shows the LoadingForm, passing the LoadingLogic instance
            LoadingForm loadingForm = new LoadingForm(loadingLogic);
            loadingForm.ShowDialog();
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void EasyModeConfirmationForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            label1.Left = (this.Width - label1.Width) / 2; //edit this after exam
            label2.Left = (this.Width - label2.Width) / 2;

            int paddingTop = 40; 
            int spacing = 40; 

           
            Yes.Left = (this.ClientSize.Width - (Yes.Width + spacing + No.Width)) / 2;
            Yes.Top = this.ClientSize.Height - Yes.Height - paddingTop;

           
            No.Left = Yes.Right + spacing;
            No.Top = Yes.Top;

        }
        //rounds form
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rounder.RoundForm(this, 60, Color.White, 8, e);
        }
    }
}
