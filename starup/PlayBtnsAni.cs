using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace starup
{
    public class PlayBtnsAni
    {
        // Timery pro různé animace
        private readonly System.Windows.Forms.Timer animationTimer;
        private readonly System.Windows.Forms.Timer fadeInTimer;
        private readonly System.Windows.Forms.Timer fadeOutTimer;

        // Proměnné pro stav animace a průhlednost
        private int animationStep;
        private float playOpacity = 1.0f;
        private float btnOpacity = 0.0f;

        // Odkazy na ovládací prvky formuláře
        private readonly PictureBox logo;
        private readonly PictureBox play;
        private readonly PictureBox btnEasy;
        private readonly PictureBox btnHard;

        // Původní velikost a umístění tlačítka "Play"
        private readonly Size originalPlaybtnSize;
        private Point originalPlaybtnLocation;
        private bool isPlayShrunk = false;

        // Konstanty pro nastavení animace
        private const int AnimationInterval = 30; // Interval animace (ms)
        private const int FadeInterval = 20;      // Interval změny průhlednosti (ms)
        private const float FadeOutStep = 0.02f;  // Krok zmenšení průhlednosti
        private const float FadeInStep = 0.04f;   // Krok zvýšení průhlednosti
        private const double ShrinkFactor = 0.9;  // Faktor zmenšení tlačítka
        private const int SlideSpeed = 2;         // Rychlost posouvání tlačítek
        private const int LogoShrinkWidth = 20;   // Zmenšení šířky loga
        private const int LogoShrinkHeight = 10;  // Zmenšení výšky loga
        private const int LogoVerticalSpeed = 10; // Vertikální rychlost loga

        // Konstruktor třídy
        public PlayBtnsAni(PictureBox logo, PictureBox play, PictureBox btnEasy, PictureBox btnHard)
        {
            this.logo = logo;
            this.play = play;
            this.btnEasy = btnEasy;
            this.btnHard = btnHard;

            // Uložení původní velikosti tlačítka
            originalPlaybtnSize = play.Size;

            // Inicializace timerů
            animationTimer = CreateTimer(AnimationInterval, AnimationTimer_Tick);
            fadeInTimer = CreateTimer(AnimationInterval, FadeInTimer_Tick);
            fadeOutTimer = CreateTimer(FadeInterval, FadeOutTimer_Tick);

            // Nastavení obsluh událostí pro ovládací prvky
            InitializeEventHandlers();
        }

        // Inicializace obsluh událostí
        private void InitializeEventHandlers()
        {
            play.MouseDown += Play_MouseDown;
            play.MouseUp += Play_MouseUp;
            btnEasy.MouseDown += (s, e) => AdjustButtonSize(btnEasy, -15);
            btnEasy.MouseUp += (s, e) => ResetButtonSize(btnEasy);
            btnHard.MouseDown += (s, e) => AdjustButtonSize(btnHard, -15);
            btnHard.MouseUp += (s, e) => ResetButtonSize(btnHard);
        }

        // Metoda pro vytvoření timeru
        private System.Windows.Forms.Timer CreateTimer(int interval, EventHandler tickEventHandler)
        {
            var timer = new System.Windows.Forms.Timer { Interval = interval }; // Vytvoření instance a nastavení intervalu
            timer.Tick += tickEventHandler; // Přidání obsluhy události
            return timer;
        }

        // Obsluha události při stisku tlačítka "Play"
        private void Play_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isPlayShrunk)
            {
                // Uložení aktuálního středu tlačítka a jeho zmenšení
                originalPlaybtnLocation = GetCenteredPosition(play);
                AdjustPlayButton(ShrinkFactor);
                isPlayShrunk = true;
            }
        }

        // Obsluha události při uvolnění tlačítka "Play"
        private void Play_MouseUp(object sender, MouseEventArgs e)
        {
            if (isPlayShrunk)
            {
                // Obnovení velikosti tlačítka a spuštění fade-out animace
                ResetPlayButton();
                isPlayShrunk = false;
                StartFadeOut();
            }
        }

        // Zmenšení tlačítka
        private void AdjustPlayButton(double factor)
        {
            play.Size = new Size((int)(play.Width * factor), (int)(play.Height * factor));
            CenterControl(play, originalPlaybtnLocation);
        }

        // Obnovení původní velikosti tlačítka
        private void ResetPlayButton()
        {
            play.Size = originalPlaybtnSize;
            CenterControl(play, originalPlaybtnLocation);
        }

        // Spuštění fade-out animace
        public void StartFadeOut()
        {
            fadeOutTimer.Start();
        }

        // Aktualizace průhlednosti při fade-out animaci
        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {
            playOpacity -= FadeOutStep;

            if (playOpacity <= 0)
            {
                // Skrytí tlačítka, když je zcela průhledné
                playOpacity = 0;
                fadeOutTimer.Stop();
                play.Visible = false;
                play.Enabled = false;
            }

            UpdateFadedImage(play, playOpacity);
        }

        // Aktualizace obrázku s průhledností
        private void UpdateFadedImage(PictureBox pictureBox, float opacity)
        {
            Bitmap fadedBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

            using (Graphics g = Graphics.FromImage(fadedBitmap))
            {
                ColorMatrix matrix = new ColorMatrix { Matrix33 = opacity };
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix);

                g.DrawImage(pictureBox.Image, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height),
                    0, 0, pictureBox.Image.Width, pictureBox.Image.Height,
                    GraphicsUnit.Pixel, attributes);
            }

            pictureBox.Image = fadedBitmap;
        }

        // Spuštění hlavní animace
        public void StartAnimation()
        {
            animationStep = 0;
            animationTimer.Start();
        }

        // Aktualizace průhlednosti tlačítek při fade-in animaci
        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            btnOpacity += FadeInStep;

            if (btnOpacity >= 1.0f)
            {
                btnOpacity = 1.0f;
                fadeInTimer.Stop();
            }

            // Aktivace tlačítek
            btnEasy.Visible = btnHard.Visible = true;
            btnEasy.Enabled = btnHard.Enabled = true;
        }

        // Animace: zmenšení loga a posun tlačítek
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            animationStep++;

            if (animationStep <= 30)
            {
                ShrinkLogo();
            }
            else if (animationStep <= 50)
            {
                if (!fadeInTimer.Enabled) fadeInTimer.Start();
                SlideButtons(btnEasy, btnHard);
            }
            else
            {
                animationTimer.Stop();
            }
        }

        // Zmenšení loga během animace

        public Size FinalLogoSize { get; private set; }
        private void ShrinkLogo()
        {
            int shrinkAmountWidth = 20; // Amount to reduce width
            int shrinkAmountHeight = 10; // Amount to reduce height

            // Calculate the new size
            int newWidth = Math.Max(logo.Width - shrinkAmountWidth, 5);
            int newHeight = Math.Max(logo.Height - shrinkAmountHeight, 5);

            FinalLogoSize = new Size(newWidth, newHeight);

            // Calculate position adjustments for both X (horizontal) and Y (vertical)
            int deltaX = (logo.Width - newWidth) / 2; // Adjust horizontally
            int deltaY = (logo.Height - newHeight) / 2; // Adjust vertically

            // Update size and position
            logo.Width = newWidth;
            logo.Height = newHeight;
            logo.Left += deltaX; // Move horizontally
            logo.Top += deltaY - 10; // Move vertically and add faster upward movement
            logo.Invalidate(); // Refresh the logo's appearance
        }

        // Posunutí tlačítek
        private void SlideButtons(params PictureBox[] buttons)
        {
            foreach (var button in buttons)
            {
                button.Top -= SlideSpeed;
            }
        }

        // Změna velikosti tlačítek při stisku a uvolnění
        private void AdjustButtonSize(PictureBox button, int sizeChange)
        {
            button.Size = new Size(button.Width + sizeChange, button.Height + sizeChange);
        }

        private void ResetButtonSize(PictureBox button)
        {
            button.Size = new Size(1273, 355);
        }

        private void CenterControl(Control control, Point center)
        {
            control.Left = center.X - control.Width / 2;
            control.Top = center.Y - control.Height / 2;
        }

        private Point GetCenteredPosition(Control control)
        {
            return new Point(control.Left + control.Width / 2, control.Top + control.Height / 2);
        }
    }
}

