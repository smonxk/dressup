

namespace starup
{
    partial class DressingLorainaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSections = new Panel();
            accBtn = new PictureBox();
            topsBtn = new PictureBox();
            shoesBtn = new PictureBox();
            bottomsBtn = new PictureBox();
            panelTops = new Panel();
            comfyDressBtn = new PictureBox();
            panelBottoms = new Panel();
            pjBottomBtn = new PictureBox();
            panelAcc = new Panel();
            brownBeltBtn = new PictureBox();
            panelShoes = new Panel();
            whiteSocksBtn = new PictureBox();
            backBtn = new PictureBox();
            panelSections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topsBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shoesBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottomsBtn).BeginInit();
            panelTops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comfyDressBtn).BeginInit();
            panelBottoms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pjBottomBtn).BeginInit();
            panelAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brownBeltBtn).BeginInit();
            panelShoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)whiteSocksBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // panelSections
            // 
            panelSections.BackColor = Color.Beige;
            panelSections.Controls.Add(accBtn);
            panelSections.Controls.Add(topsBtn);
            panelSections.Controls.Add(shoesBtn);
            panelSections.Controls.Add(bottomsBtn);
            panelSections.Location = new Point(49, 106);
            panelSections.Name = "panelSections";
            panelSections.Size = new Size(619, 96);
            panelSections.TabIndex = 10;
            // 
            // accBtn
            // 
            accBtn.BackgroundImageLayout = ImageLayout.None;
            accBtn.Image = Properties.Resources.accBtn;
            accBtn.Location = new Point(455, 24);
            accBtn.Name = "accBtn";
            accBtn.Size = new Size(122, 48);
            accBtn.SizeMode = PictureBoxSizeMode.Zoom;
            accBtn.TabIndex = 13;
            accBtn.TabStop = false;
            accBtn.Tag = "Acc";
            accBtn.Click += ShowPanelBasedOnTag;
            // 
            // topsBtn
            // 
            topsBtn.BackgroundImageLayout = ImageLayout.None;
            topsBtn.Image = Properties.Resources.topsBtn;
            topsBtn.Location = new Point(43, 24);
            topsBtn.Name = "topsBtn";
            topsBtn.Size = new Size(111, 48);
            topsBtn.SizeMode = PictureBoxSizeMode.Zoom;
            topsBtn.TabIndex = 12;
            topsBtn.TabStop = false;
            topsBtn.Tag = "Tops";
            topsBtn.Click += ShowPanelBasedOnTag;
            // 
            // shoesBtn
            // 
            shoesBtn.BackgroundImageLayout = ImageLayout.None;
            shoesBtn.Image = Properties.Resources.shoesBtn;
            shoesBtn.Location = new Point(312, 24);
            shoesBtn.Name = "shoesBtn";
            shoesBtn.Size = new Size(122, 48);
            shoesBtn.SizeMode = PictureBoxSizeMode.Zoom;
            shoesBtn.TabIndex = 11;
            shoesBtn.TabStop = false;
            shoesBtn.Tag = "Shoes";
            shoesBtn.Click += ShowPanelBasedOnTag;
            // 
            // bottomsBtn
            // 
            bottomsBtn.BackgroundImageLayout = ImageLayout.None;
            bottomsBtn.Image = Properties.Resources.bottomsBtn;
            bottomsBtn.Location = new Point(180, 24);
            bottomsBtn.Name = "bottomsBtn";
            bottomsBtn.Size = new Size(111, 48);
            bottomsBtn.SizeMode = PictureBoxSizeMode.Zoom;
            bottomsBtn.TabIndex = 10;
            bottomsBtn.TabStop = false;
            bottomsBtn.Tag = "Bottoms";
            bottomsBtn.Click += ShowPanelBasedOnTag;
            // 
            // panelTops
            // 
            panelTops.BackColor = Color.FromArgb(115, 180, 200);
            panelTops.Controls.Add(comfyDressBtn);
            panelTops.Location = new Point(30, 234);
            panelTops.Name = "panelTops";
            panelTops.Size = new Size(666, 582);
            panelTops.TabIndex = 11;
            panelTops.Tag = "Tops";
            // 
            // comfyDressBtn
            // 
            comfyDressBtn.BackColor = Color.Transparent;
            comfyDressBtn.Cursor = Cursors.Hand;
            comfyDressBtn.Image = Properties.Resources.lorDressIcon;
            comfyDressBtn.Location = new Point(28, 33);
            comfyDressBtn.Name = "comfyDressBtn";
            comfyDressBtn.Size = new Size(149, 148);
            comfyDressBtn.SizeMode = PictureBoxSizeMode.Zoom;
            comfyDressBtn.TabIndex = 2;
            comfyDressBtn.TabStop = false;
            comfyDressBtn.Tag = "itemTop";
            // 
            // panelBottoms
            // 
            panelBottoms.BackColor = Color.FromArgb(115, 180, 200);
            panelBottoms.Controls.Add(pjBottomBtn);
            panelBottoms.Location = new Point(758, 161);
            panelBottoms.Name = "panelBottoms";
            panelBottoms.Size = new Size(666, 582);
            panelBottoms.TabIndex = 12;
            panelBottoms.Tag = "Bottoms";
            panelBottoms.Visible = false;
            // 
            // pjBottomBtn
            // 
            pjBottomBtn.BackColor = Color.Transparent;
            pjBottomBtn.Cursor = Cursors.Hand;
            pjBottomBtn.Location = new Point(28, 33);
            pjBottomBtn.Name = "pjBottomBtn";
            pjBottomBtn.Size = new Size(149, 148);
            pjBottomBtn.SizeMode = PictureBoxSizeMode.Zoom;
            pjBottomBtn.TabIndex = 2;
            pjBottomBtn.TabStop = false;
            pjBottomBtn.Tag = "itemBottom";
            pjBottomBtn.Visible = false;
            // 
            // panelAcc
            // 
            panelAcc.BackColor = Color.FromArgb(115, 180, 200);
            panelAcc.Controls.Add(brownBeltBtn);
            panelAcc.Location = new Point(1057, 130);
            panelAcc.Name = "panelAcc";
            panelAcc.Size = new Size(666, 582);
            panelAcc.TabIndex = 13;
            panelAcc.Tag = "Acc";
            panelAcc.Visible = false;
            // 
            // brownBeltBtn
            // 
            brownBeltBtn.BackColor = Color.Transparent;
            brownBeltBtn.Cursor = Cursors.Hand;
            brownBeltBtn.Image = Properties.Resources.lorBeltIcon;
            brownBeltBtn.Location = new Point(28, 33);
            brownBeltBtn.Name = "brownBeltBtn";
            brownBeltBtn.Size = new Size(149, 148);
            brownBeltBtn.SizeMode = PictureBoxSizeMode.Zoom;
            brownBeltBtn.TabIndex = 2;
            brownBeltBtn.TabStop = false;
            brownBeltBtn.Tag = "itemAcc";
            // 
            // panelShoes
            // 
            panelShoes.BackColor = Color.FromArgb(115, 180, 200);
            panelShoes.Controls.Add(whiteSocksBtn);
            panelShoes.Location = new Point(718, 577);
            panelShoes.Name = "panelShoes";
            panelShoes.Size = new Size(666, 582);
            panelShoes.TabIndex = 14;
            panelShoes.Tag = "Shoes";
            panelShoes.Visible = false;
            // 
            // whiteSocksBtn
            // 
            whiteSocksBtn.BackColor = Color.Transparent;
            whiteSocksBtn.Cursor = Cursors.Hand;
            whiteSocksBtn.Image = Properties.Resources.lorSocksWhiteIcon;
            whiteSocksBtn.Location = new Point(28, 33);
            whiteSocksBtn.Name = "whiteSocksBtn";
            whiteSocksBtn.Size = new Size(149, 148);
            whiteSocksBtn.SizeMode = PictureBoxSizeMode.Zoom;
            whiteSocksBtn.TabIndex = 2;
            whiteSocksBtn.TabStop = false;
            whiteSocksBtn.Tag = "itemShoes";
            // 
            // backBtn
            // 
            backBtn.BackgroundImage = Properties.Resources.arrowBack;
            backBtn.BackgroundImageLayout = ImageLayout.Zoom;
            backBtn.Location = new Point(12, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(100, 50);
            backBtn.TabIndex = 15;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // DressingLorainaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(180, 213, 218);
            ClientSize = new Size(1920, 1080);
            Controls.Add(backBtn);
            Controls.Add(panelShoes);
            Controls.Add(panelAcc);
            Controls.Add(panelBottoms);
            Controls.Add(panelTops);
            Controls.Add(panelSections);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DressingLorainaForm";
            Tag = "Loraina";
            Text = "DressingLorainaForm";
            panelSections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)accBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)topsBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)shoesBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)bottomsBtn).EndInit();
            panelTops.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)comfyDressBtn).EndInit();
            panelBottoms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pjBottomBtn).EndInit();
            panelAcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)brownBeltBtn).EndInit();
            panelShoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)whiteSocksBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panelSections;
        private PictureBox accBtn;
        private PictureBox topsBtn;
        private PictureBox shoesBtn;
        private PictureBox bottomsBtn;
        private Panel panelTops;
        private PictureBox comfyDressBtn;
        private Panel panelBottoms;
        private PictureBox pjBottomBtn;
        private Panel panelAcc;
        private PictureBox brownBeltBtn;
        private Panel panelShoes;
        private PictureBox whiteSocksBtn;
        private PictureBox backBtn;
    }
}