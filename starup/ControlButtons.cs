using System;
using System.Drawing;
using System.Windows.Forms;

namespace starup
{
    public class FormControlButtons
    {
        private Form parentForm;
        private Button btnMinimize;
        private Button btnClose;

        public FormControlButtons(Form form, Image minimizeImage, Image closeImage)
        {
            parentForm = form;

            btnMinimize = CreateButton(minimizeImage);
            btnClose = CreateButton(closeImage);

            btnMinimize.Click += (sender, e) => MinimizeForm();
            btnClose.Click += (sender, e) => CloseForm();

            AddMouseEffects(btnMinimize);
            AddMouseEffects(btnClose);

            AddButtonsToForm();
        }

        private Button CreateButton(Image backgroundImage)
        {
            return new Button
            {
                BackgroundImage = backgroundImage,
                BackgroundImageLayout = ImageLayout.Stretch,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(50, 50),
                TabStop = false, // Prevent focus rectangle
                FlatAppearance =
                {
                    BorderSize = 0, // No border
                    MouseDownBackColor = Color.Transparent, // Transparent when clicked
                    MouseOverBackColor = Color.Transparent, // Transparent when hovered
                    CheckedBackColor = Color.Transparent
                }
            };
        }

        private void AddMouseEffects(Button button)
        {
            button.MouseDown += (sender, e) =>
            {
                button.Size = new Size(button.Width - 5, button.Height - 5); // Shrink on click
            };
            button.MouseUp += (sender, e) =>
            {
                button.Size = new Size(50, 50); // Restore size after release
            };
        }

        private void AddButtonsToForm()
        {
            parentForm.Controls.Add(btnMinimize);
            parentForm.Controls.Add(btnClose);

            PositionButtons();
        }

        private void PositionButtons()
        {
            btnMinimize.Top = 10;
            btnMinimize.Left = parentForm.ClientSize.Width - 115;

            btnClose.Top = 10;
            btnClose.Left = parentForm.ClientSize.Width - 60;

            // Ensure buttons stay positioned correctly when the form resizes
            //parentForm.Resize += (sender, e) => RepositionButtons(); - budu chtit pracovat s resizovanym oknem? 
        }

        private void RepositionButtons()
        {
            btnMinimize.Left = parentForm.ClientSize.Width - 110;
            btnClose.Left = parentForm.ClientSize.Width - 60;
        }

        private void MinimizeForm()
        {
            parentForm.WindowState = FormWindowState.Minimized;
        }

        private void CloseForm()
        {
            parentForm.Close();
        }
    }
}
