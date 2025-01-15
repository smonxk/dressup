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
            mrakydole = new PictureBox();
            mrakynahore = new PictureBox();
            btnEasy = new PictureBox();
            btnHard = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)play).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mrakydole).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mrakynahore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEasy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHard).BeginInit();
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
            play.Click += play_Click;
            // 
            // mrakydole
            // 
            mrakydole.BackColor = Color.Transparent;
            mrakydole.BackgroundImageLayout = ImageLayout.Stretch;
            mrakydole.Image = Properties.Resources.mraky;
            mrakydole.Location = new Point(1323, 699);
            mrakydole.Name = "mrakydole";
            mrakydole.Size = new Size(643, 369);
            mrakydole.SizeMode = PictureBoxSizeMode.Zoom;
            mrakydole.TabIndex = 5;
            mrakydole.TabStop = false;
            // 
            // mrakynahore
            // 
            mrakynahore.BackColor = Color.Transparent;
            mrakynahore.BackgroundImageLayout = ImageLayout.Stretch;
            mrakynahore.Image = Properties.Resources.mraky;
            mrakynahore.Location = new Point(-56, 12);
            mrakynahore.Name = "mrakynahore";
            mrakynahore.Size = new Size(670, 369);
            mrakynahore.SizeMode = PictureBoxSizeMode.Zoom;
            mrakynahore.TabIndex = 6;
            mrakynahore.TabStop = false;
            // 
            // btnEasy
            // 
            btnEasy.BackColor = Color.SkyBlue;
            btnEasy.Image = Properties.Resources.ovalbtn;
            btnEasy.Location = new Point(33, 338);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(1273, 355);
            btnEasy.SizeMode = PictureBoxSizeMode.Zoom;
            btnEasy.TabIndex = 8;
            btnEasy.TabStop = false;
            btnEasy.Visible = false;
            btnEasy.Click += btnEasy_Click;
            // 
            // btnHard
            // 
            btnHard.BackColor = Color.SkyBlue;
            btnHard.Image = Properties.Resources.ovalbtn;
            btnHard.Location = new Point(12, 699);
            btnHard.Name = "btnHard";
            btnHard.Size = new Size(1273, 355);
            btnHard.SizeMode = PictureBoxSizeMode.Zoom;
            btnHard.TabIndex = 9;
            btnHard.TabStop = false;
            btnHard.Visible = false;
            btnHard.Click += btnHard_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1920, 1080);
            Controls.Add(logo);
            Controls.Add(mrakydole);
            Controls.Add(mrakynahore);
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
            ((System.ComponentModel.ISupportInitialize)mrakydole).EndInit();
            ((System.ComponentModel.ISupportInitialize)mrakynahore).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEasy).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHard).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnMinimize;
        private Button btnClose;
        private PictureBox logo;
        private PictureBox play;
        private PictureBox mrakydole;
        private PictureBox mrakynahore;
        private PictureBox btnEasy;
        private PictureBox btnHard;
    }
}
