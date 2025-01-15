namespace starup
{
    partial class EasyModeConfirmationForm
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
            Yes = new Button();
            No = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Yes
            // 
            Yes.BackColor = Color.FromArgb(184, 50, 134);
            Yes.BackgroundImage = Properties.Resources.ovalbtn;
            Yes.BackgroundImageLayout = ImageLayout.Stretch;
            Yes.FlatAppearance.BorderSize = 0;
            Yes.FlatStyle = FlatStyle.Flat;
            Yes.Location = new Point(43, 173);
            Yes.Name = "Yes";
            Yes.Size = new Size(184, 81);
            Yes.TabIndex = 1;
            Yes.TabStop = false;
            Yes.Text = "Yes";
            Yes.UseVisualStyleBackColor = false;
            Yes.Click += Yes_Click;
            // 
            // No
            // 
            No.BackgroundImage = Properties.Resources.ovalbtn;
            No.BackgroundImageLayout = ImageLayout.Stretch;
            No.FlatAppearance.BorderSize = 0;
            No.FlatStyle = FlatStyle.Flat;
            No.ForeColor = SystemColors.ControlText;
            No.Location = new Point(288, 173);
            No.Name = "No";
            No.Size = new Size(184, 81);
            No.TabIndex = 1;
            No.TabStop = false;
            No.Text = "No";
            No.UseVisualStyleBackColor = true;
            No.Click += No_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(-12, 37);
            label1.Name = "label1";
            label1.Size = new Size(524, 51);
            label1.TabIndex = 2;
            label1.Text = "˙⋆✮ Would you like to ✮⋆˙";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(-11, 88);
            label2.Name = "label2";
            label2.Size = new Size(523, 51);
            label2.TabIndex = 3;
            label2.Text = "˙⋆✮ play Easy mode? ✮⋆˙";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // EasyModeConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(184, 50, 134);
            ClientSize = new Size(505, 285);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(No);
            Controls.Add(Yes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EasyModeConfirmationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EasyModeConfirmationForm";
            Load += EasyModeConfirmationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion      

        private Button Yes;
        private Button No;
        private Label label1;
        private Label label2;
    }
}