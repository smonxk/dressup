namespace starup
{
    partial class LoadingForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private PictureBox hvezdaLoading;
        private Label textLoading;

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
            hvezdaLoading = new PictureBox();
            textLoading = new Label();
            ((System.ComponentModel.ISupportInitialize)hvezdaLoading).BeginInit();
            SuspendLayout();
            // 
            // hvezdaLoading
            // 
            hvezdaLoading.BackColor = Color.Transparent;
            hvezdaLoading.BackgroundImageLayout = ImageLayout.Stretch;
            hvezdaLoading.Image = Properties.Resources.star_load;
            hvezdaLoading.Location = new Point(963, 282);
            hvezdaLoading.Name = "hvezdaLoading";
            hvezdaLoading.Size = new Size(289, 262);
            hvezdaLoading.SizeMode = PictureBoxSizeMode.Zoom;
            hvezdaLoading.TabIndex = 0;
            hvezdaLoading.TabStop = false;
            // 
            // textLoading
            // 
            textLoading.AutoSize = true;
            textLoading.Font = new Font("Arial", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textLoading.ForeColor = Color.White;
            textLoading.Location = new Point(634, 701);
            textLoading.Name = "textLoading";
            textLoading.Size = new Size(985, 51);
            textLoading.TabIndex = 1;
            textLoading.Text = "˙⋆✮ Fabulous fashionventure awaits you . . . ✮⋆˙";
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(184, 50, 134);
            ClientSize = new Size(1904, 1041);
            Controls.Add(textLoading);
            Controls.Add(hvezdaLoading);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoadingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadingForm";
            WindowState = FormWindowState.Maximized;
            Load += LoadingForm_Load;
            ((System.ComponentModel.ISupportInitialize)hvezdaLoading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

    }
}