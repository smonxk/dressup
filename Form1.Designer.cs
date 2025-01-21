namespace starup
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMinimize = new Button();
            btnClose = new Button();
            logo = new PictureBox();
            play = new PictureBox();
            mrakyDole = new PictureBox();
            btnEasy = new PictureBox();
            btnHard = new PictureBox();
            mrakyNahore = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)play).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mrakyDole).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEasy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mrakyNahore).BeginInit();
            SuspendLayout();
            // 
            // btnMinimize
            // 
            btnMinimize.Location = new Point(0, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(75, 23);
            btnMinimize.TabIndex = 11;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(0, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 10;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logo.BackColor = Color.Transparent;
            logo.BackgroundImageLayout = ImageLayout.Zoom;
            logo.Image = Properties.Resources.prototype_logo;
            logo.Location = new Point(321, 172);
            logo.Name = "logo";
            logo.Size = new Size(1024, 473);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 3;
            logo.TabStop = false;
            // 
            // play
            // 
            play.BackColor = Color.SkyBlue;
            play.BackgroundImageLayout = ImageLayout.Zoom;
            play.Image = Properties.Resources.prototype_play;
            play.Location = new Point(604, 674);
            play.Name = "play";
            play.Size = new Size(422, 198);
            play.SizeMode = PictureBoxSizeMode.Zoom;
            play.TabIndex = 4;
            play.TabStop = false;
            play.Click += Play_Click;
            // 
            // mrakyDole
            // 
            mrakyDole.BackColor = Color.Transparent;
            mrakyDole.BackgroundImageLayout = ImageLayout.Stretch;
            mrakyDole.Image = Properties.Resources.mraky;
            mrakyDole.Location = new Point(1323, 699);
            mrakyDole.Name = "mrakyDole";
            mrakyDole.Size = new Size(643, 369);
            mrakyDole.SizeMode = PictureBoxSizeMode.Zoom;
            mrakyDole.TabIndex = 5;
            mrakyDole.TabStop = false;
            // 
            // btnEasy
            // 
            btnEasy.BackColor = Color.SkyBlue;
            btnEasy.Image = Properties.Resources.playBtn;
            btnEasy.Location = new Point(33, 338);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(1273, 355);
            btnEasy.SizeMode = PictureBoxSizeMode.Zoom;
            btnEasy.TabIndex = 8;
            btnEasy.TabStop = false;
            btnEasy.Visible = false;
            btnEasy.Click += BtnEasy_Click;
            // 
            // btnHard
            // 
            btnHard.BackColor = Color.SkyBlue;
            btnHard.Image = Properties.Resources.aboutBtn;
            btnHard.Location = new Point(12, 699);
            btnHard.Name = "btnHard";
            btnHard.Size = new Size(1273, 355);
            btnHard.SizeMode = PictureBoxSizeMode.Zoom;
            btnHard.TabIndex = 9;
            btnHard.TabStop = false;
            btnHard.Visible = false;
            btnHard.Click += BtnHard_Click;
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
            mrakyNahore.TabIndex = 6;
            mrakyNahore.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1920, 1080);
            Controls.Add(logo);
            Controls.Add(mrakyDole);
            Controls.Add(mrakyNahore);
            Controls.Add(btnHard);
            Controls.Add(btnEasy);
            Controls.Add(play);
            Controls.Add(btnClose);
            Controls.Add(btnMinimize);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)play).EndInit();
            ((System.ComponentModel.ISupportInitialize)mrakyDole).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEasy).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHard).EndInit();
            ((System.ComponentModel.ISupportInitialize)mrakyNahore).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnMinimize;
        private Button btnClose;
        private PictureBox logo;
        private PictureBox play;
        private PictureBox mrakyDole;
        private PictureBox btnEasy;
        private PictureBox btnHard;
        private PictureBox mrakyNahore;
    }
}
