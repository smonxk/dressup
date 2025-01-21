using System;
using System.Drawing;
using System.Windows.Forms;

namespace starup
{
    public partial class InfoCharForm : Form
    {
        private Shrinker shrinker;
        private LayoutManager layoutManager;

        private const int ShrinkWidth = 20;
        private const int ShrinkHeight = 10;

        public InfoCharForm(string characterName, string description)
        {
            InitializeComponent();

            // initializes helping classes
            shrinker = new Shrinker();
            layoutManager = new LayoutManager(this);

            labelName.Text = characterName;
            charDescription.Text = description;
            
            layoutManager.ControlPosition(labelName, 10, -270);
            layoutManager.ControlPosition(charDescription, -20, -30);
            layoutManager.ControlPosition(scrollablePanel, -20, -30);
            layoutManager.ControlPosition(okBtn, 10, 250);

            AddCustomScrollbar(scrollablePanel);

           
            okBtn.MouseDown += OkMouseDown;
            okBtn.MouseUp += OkMouseUp;

            Rounder.RoundLabel(charDescription, 60, Color.FromArgb(184, 50, 134), 2); 
            Rounder.RoundPanel(scrollablePanel, 60, Color.FromArgb(184, 50, 134), 2); 
        }

        private void AddCustomScrollbar(Panel panel)
        {
            var scrollbar = new CustomScrollbar(panel, Color.FromArgb(184, 50, 134), 10);
            scrollbar.AttachToParent(this);
            scrollbar.BackColor = Color.FromArgb(243, 209, 228);
        }

        private void OkMouseDown(object sender, MouseEventArgs e)
        {
            shrinker.ResizeControl(okBtn, -ShrinkWidth, -ShrinkHeight);
        }

        private void OkMouseUp(object sender, MouseEventArgs e)
        {
            shrinker.ResizeControl(okBtn, ShrinkWidth, ShrinkHeight);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rounder.RoundForm(this, 60, Color.FromArgb(184, 50, 134), 8, e);
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
