
using System;
using System.Drawing;
using System.Windows.Forms;

namespace starup
{
    public partial class DressingInerysForm : Form
    {
        private ClothingItemManagement clothingItemManagement;
        private Panel panel;
        private FormControlButtons formControlButtons;
        private Shrinker shrinker;

        private Image currentBaseImage;
        private Image currentHairImage;

        public DressingInerysForm()
        {
            InitializeComponent();
            RoundPictureboxes();
            RoundPanels();

            formControlButtons = new FormControlButtons(
                this,
                Properties.Resources.minimize,
                Properties.Resources.close,
                Properties.Resources.arrowBack
            );

            shrinker = new Shrinker();

            //drawing panel
            panel = new Panel
            {
                Location = new Point(950, 60),
                Size = new Size(498, 1001)
            };

            
            this.Controls.Add(panel);

          
            panel.Paint += new PaintEventHandler(Panel_Paint);

           
            clothingItemManagement = new ClothingItemManagement();
            currentBaseImage = Properties.Resources.ineBase;
            currentHairImage = Properties.Resources.ineHair1;
          
        }


       
        private void TagPictureBox_Click(object sender, EventArgs e)
        {
            var clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox == null) return;

            // tag to determine image
            var tag = clickedPictureBox.Tag?.ToString();

            string characterName = "Inerys"; 
            clothingItemManagement.ToggleItem(
                clickedPictureBox,
                (itemName) => ImageFinder.GetImageByName(characterName, itemName),  
                this
            );

            
            panel.Invalidate();
        }

        // paint event for painting panel
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            var panel = sender as Panel;
            if (panel == null) return;

            // class panelrenderinghelper to render the clothing items with the current base image
            PanelRenderingHelper.RenderClothingItems(e, clothingItemManagement, currentBaseImage, currentHairImage);
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            var control = sender as Control;
            if (control != null)
            {
                shrinker.ResizeControl(control, -20, -10);
            }
        }

        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            var control = sender as Control;
            if (control != null)
            {
                shrinker.ResizeControl(control, 20, 10);
            }
        }

        private void ShowPanelBasedOnTag(object sender, EventArgs e)
        {
            var clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox == null) return;

            // gets the tag of the clicked pb
            var tag = clickedPictureBox.Tag?.ToString();

            // toggles visibility based on the tag
            foreach (Control control in this.Controls)
            {
                if (control is Panel panel && panel != this.panel && panel != this.panelSections) 
                {
                    // cheksif the tag matches the panel's tag, and set visibility
                    if (panel.Tag?.ToString() == tag)
                    {
                        panel.Visible = true;  
                        panel.Location = new Point(30, 234);  // sets the position of the panel
                    }
                    else
                    {
                        panel.Visible = false;  // Hide the other panels
                    }
                }
            }
        }

        void RoundPictureboxes()
        {
            foreach (var control in new[] { pjTopBtn, pjBottomBtn, pjShoesBtn, blueHairpinBtn })
            {
                if (control.Tag != null)
                {
                    Rounder.RoundPictureBox(control as PictureBox, 40);
                }
            }
        }

        void RoundPanels()
        {
            foreach (var control in new[] { panelSections, panelTops, panelBottoms, panelAcc, panelShoes })
            {
                if (control != null)
                {
                    Rounder.RoundPanel(control as Panel, 40, Color.Transparent, 0); // apllies rounding to the panel without a border
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            ChooseCharForm chooseCharForm = new ChooseCharForm();

            this.Dispose();

            var chooseForm = new ChooseCharForm();
            chooseForm.ShowDialog();
        }
    }
}



