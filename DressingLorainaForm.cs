using System;
using System.Drawing;
using System.Windows.Forms;

namespace starup
{
    public partial class DressingLorainaForm : Form
    {
        private ClothingItemManagement clothingItemManagement;
        private Panel panel;
        private FormControlButtons formControlButtons;
        private Shrinker shrinker;

        private Image currentBaseImage;
        private Image currentHairImage;

        public DressingLorainaForm()
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
            AttachResizeEventHandlers();

            // drawing panel
            panel = new Panel
            {
                Location = new Point(950, 60),
                Size = new Size(498, 1001)
            };

            
            this.Controls.Add(panel);

            // attaching drawing event to drawing panel
            panel.Paint += new PaintEventHandler(Panel_Paint);

          
            clothingItemManagement = new ClothingItemManagement();
            currentBaseImage = Properties.Resources.lorBase;
            currentHairImage = Properties.Resources.lorHair;
      
            AttachClickEventHandlers();
        }

        private void AttachClickEventHandlers() //helper method
        {
            foreach (var control in new[] { comfyDressBtn, brownBeltBtn, whiteSocksBtn })
            {
                control.Click += new EventHandler(TagPictureBox_Click);
            }
        }

        private void TagPictureBox_Click(object sender, EventArgs e)
        {
            var clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox == null) return;

            // tag  of the clicked pb to determine the image
            var tag = clickedPictureBox.Tag?.ToString();

            string characterName = "Loraina"; 
            clothingItemManagement.ToggleItem(
                clickedPictureBox,
                (itemName) => ImageFinder.GetImageByName(characterName, itemName),  // gets clothes form image finder class for drawing panel
                this
            );

           
            panel.Invalidate();
        }

        // paint event for painting panel
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            var panel = sender as Panel;
            if (panel == null) return;

            PanelRenderingHelper.RenderClothingItems(e, clothingItemManagement, currentBaseImage, currentHairImage);
        }

        private void AttachResizeEventHandlers()
        {
            foreach (var control in new[] { topsBtn, bottomsBtn, shoesBtn, accBtn, comfyDressBtn, brownBeltBtn, whiteSocksBtn, backBtn })
            {
                control.MouseDown += Control_MouseDown;
                control.MouseUp += Control_MouseUp;
            }
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

       
            var tag = clickedPictureBox.Tag?.ToString();

            // toggle panel visibility based on the 
            foreach (Control control in this.Controls)
            {
                if (control is Panel panel && panel != this.panel && panel != this.panelSections) 
                {
                   
                    if (panel.Tag?.ToString() == tag)
                    {
                        panel.Visible = true;  // shows the matching panel
                        panel.Location = new Point(30, 234);  
                    }
                    else
                    {
                        panel.Visible = false;  //hides other panels
                    }
                }
            }
        }

        void RoundPictureboxes()
        {
            foreach (var control in new[] { comfyDressBtn, brownBeltBtn, whiteSocksBtn })
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
                    Rounder.RoundPanel(control as Panel, 40, Color.Transparent, 0); // Apply rounding to the panel without a border
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


