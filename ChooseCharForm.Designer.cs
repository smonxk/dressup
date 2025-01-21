namespace starup
{
    partial class ChooseCharForm
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
            charInerys = new PictureBox();
            charLoraina = new PictureBox();
            charTygistae = new PictureBox();
            charAvalon = new PictureBox();
            playTygistae = new PictureBox();
            playInerys = new PictureBox();
            playLoraina = new PictureBox();
            playAvalon = new PictureBox();
            infoAvalon = new PictureBox();
            infoTygistae = new PictureBox();
            infoInerys = new PictureBox();
            infoLoraina = new PictureBox();
            mrakyNahore = new PictureBox();
            mrakyDole = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)charInerys).BeginInit();
            ((System.ComponentModel.ISupportInitialize)charLoraina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)charTygistae).BeginInit();
            ((System.ComponentModel.ISupportInitialize)charAvalon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playTygistae).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playInerys).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playLoraina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playAvalon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoAvalon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoTygistae).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoInerys).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoLoraina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mrakyNahore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mrakyDole).BeginInit();
            SuspendLayout();
            // 
            // charInerys
            // 
            charInerys.BackColor = Color.Transparent;
            charInerys.BackgroundImageLayout = ImageLayout.Zoom;
            charInerys.Image = Properties.Resources.Inerys1;
            charInerys.Location = new Point(485, 177);
            charInerys.Name = "charInerys";
            charInerys.Size = new Size(517, 714);
            charInerys.SizeMode = PictureBoxSizeMode.Zoom;
            charInerys.TabIndex = 0;
            charInerys.TabStop = false;
            charInerys.Visible = false;
            // 
            // charLoraina
            // 
            charLoraina.BackgroundImageLayout = ImageLayout.Zoom;
            charLoraina.Image = Properties.Resources.Lorainel1;
            charLoraina.Location = new Point(936, 177);
            charLoraina.Name = "charLoraina";
            charLoraina.Size = new Size(464, 714);
            charLoraina.SizeMode = PictureBoxSizeMode.Zoom;
            charLoraina.TabIndex = 1;
            charLoraina.TabStop = false;
            charLoraina.Visible = false;
            // 
            // charTygistae
            // 
            charTygistae.BackgroundImageLayout = ImageLayout.Zoom;
            charTygistae.ErrorImage = Properties.Resources.Bez_názvu;
            charTygistae.Image = Properties.Resources.prototype_play;
            charTygistae.Location = new Point(1633, 168);
            charTygistae.Name = "charTygistae";
            charTygistae.Size = new Size(443, 695);
            charTygistae.SizeMode = PictureBoxSizeMode.Zoom;
            charTygistae.TabIndex = 2;
            charTygistae.TabStop = false;
            charTygistae.Visible = false;
            // 
            // charAvalon
            // 
            charAvalon.BackgroundImageLayout = ImageLayout.Zoom;
            charAvalon.Image = Properties.Resources.prototype_play;
            charAvalon.Location = new Point(1646, 302);
            charAvalon.Name = "charAvalon";
            charAvalon.Size = new Size(408, 695);
            charAvalon.SizeMode = PictureBoxSizeMode.Zoom;
            charAvalon.TabIndex = 3;
            charAvalon.TabStop = false;
            charAvalon.Visible = false;
            // 
            // playTygistae
            // 
            playTygistae.BackColor = Color.Transparent;
            playTygistae.BackgroundImageLayout = ImageLayout.Stretch;
            playTygistae.Image = Properties.Resources.ovalbtn;
            playTygistae.Location = new Point(1705, 792);
            playTygistae.Name = "playTygistae";
            playTygistae.Size = new Size(349, 121);
            playTygistae.SizeMode = PictureBoxSizeMode.Zoom;
            playTygistae.TabIndex = 4;
            playTygistae.TabStop = false;
            playTygistae.Tag = "Tygistae";
            playTygistae.Visible = false;
            playTygistae.Click += PlayPictureBox_Click;
            // 
            // playInerys
            // 
            playInerys.BackColor = Color.Transparent;
            playInerys.BackgroundImageLayout = ImageLayout.Stretch;
            playInerys.Image = Properties.Resources.ineBtn;
            playInerys.Location = new Point(556, 897);
            playInerys.Name = "playInerys";
            playInerys.Size = new Size(349, 121);
            playInerys.SizeMode = PictureBoxSizeMode.Zoom;
            playInerys.TabIndex = 5;
            playInerys.TabStop = false;
            playInerys.Tag = "Inerys";
            playInerys.Visible = false;
            playInerys.Click += PlayPictureBox_Click;
            // 
            // playLoraina
            // 
            playLoraina.BackColor = Color.Transparent;
            playLoraina.BackgroundImageLayout = ImageLayout.Stretch;
            playLoraina.Image = Properties.Resources.lorBtn;
            playLoraina.Location = new Point(1000, 897);
            playLoraina.Name = "playLoraina";
            playLoraina.Size = new Size(349, 121);
            playLoraina.SizeMode = PictureBoxSizeMode.Zoom;
            playLoraina.TabIndex = 6;
            playLoraina.TabStop = false;
            playLoraina.Tag = "Loraina";
            playLoraina.Visible = false;
            playLoraina.Click += PlayPictureBox_Click;
            // 
            // playAvalon
            // 
            playAvalon.BackColor = Color.Transparent;
            playAvalon.BackgroundImageLayout = ImageLayout.Stretch;
            playAvalon.Image = Properties.Resources.ovalbtn;
            playAvalon.Location = new Point(1705, 937);
            playAvalon.Name = "playAvalon";
            playAvalon.Size = new Size(349, 121);
            playAvalon.SizeMode = PictureBoxSizeMode.Zoom;
            playAvalon.TabIndex = 7;
            playAvalon.TabStop = false;
            playAvalon.Tag = "Avalon";
            playAvalon.Visible = false;
            playAvalon.Click += PlayPictureBox_Click;
            // 
            // infoAvalon
            // 
            infoAvalon.BackgroundImageLayout = ImageLayout.Zoom;
            infoAvalon.Image = Properties.Resources.infobtn;
            infoAvalon.Location = new Point(1844, 239);
            infoAvalon.Name = "infoAvalon";
            infoAvalon.Size = new Size(80, 57);
            infoAvalon.SizeMode = PictureBoxSizeMode.Zoom;
            infoAvalon.TabIndex = 8;
            infoAvalon.TabStop = false;
            infoAvalon.Tag = "Avalon";
            infoAvalon.Visible = false;
            infoAvalon.Click += InfoPictureBox_Click;
            // 
            // infoTygistae
            // 
            infoTygistae.BackgroundImageLayout = ImageLayout.Zoom;
            infoTygistae.Image = Properties.Resources.infobtn;
            infoTygistae.Location = new Point(1828, 105);
            infoTygistae.Name = "infoTygistae";
            infoTygistae.Size = new Size(80, 57);
            infoTygistae.SizeMode = PictureBoxSizeMode.Zoom;
            infoTygistae.TabIndex = 9;
            infoTygistae.TabStop = false;
            infoTygistae.Tag = "Tygistae";
            infoTygistae.Visible = false;
            infoTygistae.Click += InfoPictureBox_Click;
            // 
            // infoInerys
            // 
            infoInerys.BackgroundImageLayout = ImageLayout.Zoom;
            infoInerys.Image = Properties.Resources.infobtn;
            infoInerys.Location = new Point(701, 105);
            infoInerys.Name = "infoInerys";
            infoInerys.Size = new Size(80, 57);
            infoInerys.SizeMode = PictureBoxSizeMode.Zoom;
            infoInerys.TabIndex = 10;
            infoInerys.TabStop = false;
            infoInerys.Tag = "Inerys";
            infoInerys.Visible = false;
            infoInerys.Click += InfoPictureBox_Click;
            // 
            // infoLoraina
            // 
            infoLoraina.BackgroundImageLayout = ImageLayout.Zoom;
            infoLoraina.Image = Properties.Resources.infobtn;
            infoLoraina.Location = new Point(1124, 105);
            infoLoraina.Name = "infoLoraina";
            infoLoraina.Size = new Size(80, 57);
            infoLoraina.SizeMode = PictureBoxSizeMode.Zoom;
            infoLoraina.TabIndex = 11;
            infoLoraina.TabStop = false;
            infoLoraina.Tag = "Lorainael";
            infoLoraina.Visible = false;
            infoLoraina.Click += InfoPictureBox_Click;
            // 
            // mrakyNahore
            // 
            mrakyNahore.BackColor = Color.Transparent;
            mrakyNahore.BackgroundImageLayout = ImageLayout.Stretch;
            mrakyNahore.Image = Properties.Resources.mraky;
            mrakyNahore.Location = new Point(-70, 0);
            mrakyNahore.Name = "mrakyNahore";
            mrakyNahore.Size = new Size(670, 369);
            mrakyNahore.SizeMode = PictureBoxSizeMode.Zoom;
            mrakyNahore.TabIndex = 12;
            mrakyNahore.TabStop = false;
            // 
            // mrakyDole
            // 
            mrakyDole.BackColor = Color.Transparent;
            mrakyDole.BackgroundImageLayout = ImageLayout.Stretch;
            mrakyDole.Image = Properties.Resources.mraky;
            mrakyDole.Location = new Point(1323, 699);
            mrakyDole.Name = "mrakyDole";
            mrakyDole.Size = new Size(670, 369);
            mrakyDole.SizeMode = PictureBoxSizeMode.Zoom;
            mrakyDole.TabIndex = 13;
            mrakyDole.TabStop = false;
            // 
            // ChooseCharForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1920, 1080);
            Controls.Add(mrakyDole);
            Controls.Add(mrakyNahore);
            Controls.Add(infoInerys);
            Controls.Add(infoAvalon);
            Controls.Add(infoTygistae);
            Controls.Add(infoLoraina);
            Controls.Add(playAvalon);
            Controls.Add(playLoraina);
            Controls.Add(playInerys);
            Controls.Add(playTygistae);
            Controls.Add(charAvalon);
            Controls.Add(charTygistae);
            Controls.Add(charLoraina);
            Controls.Add(charInerys);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChooseCharForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChooseChar";
            WindowState = FormWindowState.Maximized;
            Load += ChooseChar_Load;
            ((System.ComponentModel.ISupportInitialize)charInerys).EndInit();
            ((System.ComponentModel.ISupportInitialize)charLoraina).EndInit();
            ((System.ComponentModel.ISupportInitialize)charTygistae).EndInit();
            ((System.ComponentModel.ISupportInitialize)charAvalon).EndInit();
            ((System.ComponentModel.ISupportInitialize)playTygistae).EndInit();
            ((System.ComponentModel.ISupportInitialize)playInerys).EndInit();
            ((System.ComponentModel.ISupportInitialize)playLoraina).EndInit();
            ((System.ComponentModel.ISupportInitialize)playAvalon).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoAvalon).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoTygistae).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoInerys).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoLoraina).EndInit();
            ((System.ComponentModel.ISupportInitialize)mrakyNahore).EndInit();
            ((System.ComponentModel.ISupportInitialize)mrakyDole).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox charInerys;
        private PictureBox charLoraina;
        private PictureBox charTygistae;
        private PictureBox charAvalon;
        private PictureBox playTygistae;
        private PictureBox playInerys;
        private PictureBox playLoraina;
        private PictureBox playAvalon;
        private PictureBox infoAvalon;
        private PictureBox infoTygistae;
        private PictureBox infoInerys;
        private PictureBox infoLoraina;
        private PictureBox mrakyNahore;
        private PictureBox mrakyDole;
    }
}
