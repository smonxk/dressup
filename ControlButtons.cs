using System;
using System.Drawing;
using System.Windows.Forms;

namespace starup
{
    public class FormControlButtons
    {
        private readonly Form _parentForm;
        private readonly Button _btnMinimize;
        private readonly Button _btnClose;
        private readonly PictureBox _btnBack; 

        private const int ButtonSize = 50;

        public FormControlButtons(Form form, Image minimizeImage, Image closeImage, Image backImage = null)
        {
            _parentForm = form ?? throw new ArgumentNullException(nameof(form));

            // main buttons should be mandatory
            _btnMinimize = CreateButton(minimizeImage, MinimizeForm);
            _btnClose = CreateButton(closeImage, CloseForm);

            if (backImage != null)
            {
                _btnBack = CreateBackButton(backImage); // this button is not mandatory because it is exclusively for dressing forms
            }

            AddMouseEffects(_btnMinimize);
            AddMouseEffects(_btnClose);

            AddButtonsToForm();
        }

        private Button CreateButton(Image backgroundImage, EventHandler clickHandler)
        {
            if (backgroundImage == null) throw new ArgumentNullException(nameof(backgroundImage));

            var button = new Button
            {
                BackgroundImage = backgroundImage,
                BackgroundImageLayout = ImageLayout.Stretch,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(ButtonSize, ButtonSize),
                TabStop = false, 
            };

            
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatAppearance.CheckedBackColor = Color.Transparent;

            button.Click += clickHandler; 

            return button;
        }

        private PictureBox CreateBackButton(Image backImage)
        {
            var pictureBox = new PictureBox
            {
                BackgroundImage = backImage,
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(100, 50), 
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand, 
                Location = new Point(12, 12),
            };

            pictureBox.Click += BackButton_Click;
            return pictureBox;
        }

        private void AddMouseEffects(Button button)
        {
            button.MouseDown += (_, _) => ResizeButton(button, -5); // shrinks when clicked
            button.MouseUp += (_, _) => ResizeButton(button, 0);   // initial size when released
        }

        private void ResizeButton(Button button, int adjustment)
        {
            int newSize = ButtonSize + adjustment;
            button.Size = new Size(newSize, newSize);
        }

        private void AddButtonsToForm()
        {
            _parentForm.Controls.Add(_btnMinimize);
            _parentForm.Controls.Add(_btnClose);

            if (_btnBack != null)
            {
                _parentForm.Controls.Add(_btnBack); // adds button to the form only if it exits
            }

            PositionButtons();
        }

        private void PositionButtons()
        {
            _btnMinimize.Top = 10;
            _btnMinimize.Left = _parentForm.ClientSize.Width - 125;

            _btnClose.Top = 10;
            _btnClose.Left = _parentForm.ClientSize.Width - 60;

            if (_btnBack != null)
            {
                _btnBack.Location = new Point(12, 12); //maybe edit later after exam
            }
        }

        private void MinimizeForm(object sender, EventArgs e)
        {
            _parentForm.WindowState = FormWindowState.Minimized;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
            var chooseCharForm = new ChooseCharForm();
            _parentForm.Dispose(); // disposes the current form
            chooseCharForm.Show(); // shows the ChooseCharForm
        }
    }
}
