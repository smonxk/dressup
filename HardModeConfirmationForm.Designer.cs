namespace starup
{
    partial class HardModeConfirmationForm
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
            panelGameInfo = new Panel();
            infoTextBox = new RichTextBox();
            pictureBox1 = new PictureBox();
            okHardBtn = new Button();
            panelGameInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelGameInfo
            // 
            panelGameInfo.AutoScroll = true;
            panelGameInfo.BackColor = Color.FromArgb(243, 209, 228);
            panelGameInfo.Controls.Add(infoTextBox);
            panelGameInfo.Location = new Point(34, 74);
            panelGameInfo.Name = "panelGameInfo";
            panelGameInfo.Size = new Size(717, 336);
            panelGameInfo.TabIndex = 0;
            // 
            // infoTextBox
            // 
            infoTextBox.BackColor = Color.FromArgb(243, 209, 228);
            infoTextBox.BorderStyle = BorderStyle.None;
            infoTextBox.Enabled = false;
            infoTextBox.ForeColor = Color.FromArgb(184, 50, 134);
            infoTextBox.Location = new Point(0, 3);
            infoTextBox.Name = "infoTextBox";
            infoTextBox.ReadOnly = true;
            infoTextBox.ScrollBars = RichTextBoxScrollBars.None;
            infoTextBox.Size = new Size(717, 333);
            infoTextBox.TabIndex = 2;
            infoTextBox.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.warningSign;
            pictureBox1.Location = new Point(363, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // okHardBtn
            // 
            okHardBtn.BackgroundImage = Properties.Resources.okBtn;
            okHardBtn.BackgroundImageLayout = ImageLayout.Zoom;
            okHardBtn.FlatAppearance.BorderSize = 0;
            okHardBtn.FlatStyle = FlatStyle.Flat;
            okHardBtn.Location = new Point(263, 426);
            okHardBtn.Name = "okHardBtn";
            okHardBtn.Size = new Size(279, 57);
            okHardBtn.TabIndex = 1;
            okHardBtn.UseVisualStyleBackColor = true;
            okHardBtn.Click += OkHardBtn_Click;
            // 
            // HardModeConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(184, 50, 134);
            ClientSize = new Size(800, 491);
            ControlBox = false;
            Controls.Add(okHardBtn);
            Controls.Add(pictureBox1);
            Controls.Add(panelGameInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HardModeConfirmationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HardModeConfirmationForm";
            Load += HardModeConfirmationForm_Load;
            panelGameInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGameInfo;
        private PictureBox pictureBox1;
        private Button okHardBtn;
        private RichTextBox infoTextBox;
    }
}