namespace starup
{
    partial class InfoCharForm
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
            okBtn = new PictureBox();
            labelName = new Label();
            charDescription = new Label();
            scrollablePanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)okBtn).BeginInit();
            scrollablePanel.SuspendLayout();
            SuspendLayout();
            // 
            // okBtn
            // 
            okBtn.BackgroundImageLayout = ImageLayout.Stretch;
            okBtn.Image = Properties.Resources.ovalbtn;
            okBtn.Location = new Point(43, 493);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(400, 88);
            okBtn.SizeMode = PictureBoxSizeMode.Zoom;
            okBtn.TabIndex = 0;
            okBtn.TabStop = false;
            okBtn.Click += okBtn_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Arial Black", 22F, FontStyle.Bold | FontStyle.Underline);
            labelName.ForeColor = Color.FromArgb(184, 50, 134);
            labelName.Location = new Point(183, 28);
            labelName.Name = "labelName";
            labelName.Size = new Size(128, 42);
            labelName.TabIndex = 2;
            labelName.Text = "Jméno";
            labelName.TextAlign = ContentAlignment.TopCenter;
            // 
            // charDescription
            // 
            charDescription.AutoSize = true;
            charDescription.BackColor = Color.White;
            charDescription.Font = new Font("Arial", 12F, FontStyle.Bold);
            charDescription.ForeColor = Color.FromArgb(184, 50, 134);
            charDescription.Location = new Point(5, 5);
            charDescription.MaximumSize = new Size(386, 0);
            charDescription.Name = "charDescription";
            charDescription.Size = new Size(45, 19);
            charDescription.TabIndex = 3;
            charDescription.Text = "kkkk";
            charDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scrollablePanel
            // 
            scrollablePanel.AutoScroll = true;
            scrollablePanel.Controls.Add(charDescription);
            scrollablePanel.Location = new Point(43, 83);
            scrollablePanel.Name = "scrollablePanel";
            scrollablePanel.Padding = new Padding(5);
            scrollablePanel.Size = new Size(400, 404);
            scrollablePanel.TabIndex = 4;
            // 
            // InfoCharForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(243, 209, 228);
            ClientSize = new Size(481, 626);
            ControlBox = false;
            Controls.Add(labelName);
            Controls.Add(okBtn);
            Controls.Add(scrollablePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoCharForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "InfoPostava";
            ((System.ComponentModel.ISupportInitialize)okBtn).EndInit();
            scrollablePanel.ResumeLayout(false);
            scrollablePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox okBtn;
        private Label labelName;
        private Label charDescription;
        private Panel scrollablePanel;
    }
}