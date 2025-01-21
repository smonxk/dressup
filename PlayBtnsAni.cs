using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace starup
{
    public class PlayBtnsAni
    {
        private readonly Timer animationTimer;
        private readonly Timer fadeInTimer;
        private readonly Timer fadeOutTimer;

        private int animationStep;
        private float playOpacity = 1.0f;
        private float btnOpacity = 0.0f;

        private readonly PictureBox logo;
        private readonly PictureBox play;
        private readonly PictureBox btnEasy;
        private readonly PictureBox btnHard;

        private readonly Size originalPlaybtnSize;
        private Point originalPlaybtnLocation;
        private bool isPlayShrunk = false;

        private const int AnimationInterval = 30;
        private const int FadeInterval = 20;
        private const float FadeOutStep = 0.02f;
        private const float FadeInStep = 0.04f;
        private const double ShrinkFactor = 0.9;
        private const int SlideSpeed = 2;

        private readonly Shrinker shrinker;

        // constructor to initialize objects and timers
        public PlayBtnsAni(PictureBox logo, PictureBox play, PictureBox btnEasy, PictureBox btnHard)
        {
            this.logo = logo;
            this.play = play;
            this.btnEasy = btnEasy;
            this.btnHard = btnHard;

            originalPlaybtnSize = play.Size;

            // create timers with specific intervals and event handlers
            animationTimer = CreateTimer(AnimationInterval, AnimationTimer_Tick);
            fadeInTimer = CreateTimer(AnimationInterval, FadeInTimer_Tick);
            fadeOutTimer = CreateTimer(FadeInterval, FadeOutTimer_Tick);

            shrinker = new Shrinker(); // initialize the Shrinker instance

            InitializeEventHandlers();
        }

        // method to create and return a new timer
        private Timer CreateTimer(int interval, EventHandler tickEventHandler)
        {
            var timer = new Timer { Interval = interval };
            timer.Tick += tickEventHandler;
            return timer;
        }

        // initialize event handlers for mouse actions on play and buttons
        private void InitializeEventHandlers()
        {
            play.MouseDown += Play_MouseDown;
            play.MouseUp += Play_MouseUp;

            btnEasy.MouseDown += (s, e) => shrinker.ResizeControl(btnEasy, -15, -15);
            btnEasy.MouseUp += (s, e) => shrinker.ResizeControl(btnEasy, 15, 15);

            btnHard.MouseDown += (s, e) => shrinker.ResizeControl(btnHard, -15, -15);
            btnHard.MouseUp += (s, e) => shrinker.ResizeControl(btnHard, 15, 15);
        }

        // when mouse is pressed on play button, shrink the button
        private void Play_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isPlayShrunk)
            {
                originalPlaybtnLocation = GetCenteredPosition(play);  // store current position
                AdjustPlayButton(ShrinkFactor); // shrink the button
                isPlayShrunk = true;
            }
        }

        // when mouse is released on play button, reset the button and start fade out
        private void Play_MouseUp(object sender, MouseEventArgs e)
        {
            if (isPlayShrunk)
            {
                ResetPlayButton();  // reset button size
                isPlayShrunk = false;
                StartFadeOut(); // start fade out effect
            }
        }

        // adjust the play button size using the given shrink factor
        private void AdjustPlayButton(double factor)
        {
            play.Size = new Size((int)(play.Width * factor), (int)(play.Height * factor));
            CenterControl(play, originalPlaybtnLocation); // center the play button
        }

        // reset the play button to its original size
        private void ResetPlayButton()
        {
            play.Size = originalPlaybtnSize;
            CenterControl(play, originalPlaybtnLocation);
        }

        // start fading out the play button
        public void StartFadeOut()
        {
            fadeOutTimer.Start();
        }

        // handle fade out effect on the play button
        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {
            playOpacity -= FadeOutStep; // decrease opacity

            if (playOpacity <= 0)
            {
                playOpacity = 0; // make opacity 0 when fully faded
                fadeOutTimer.Stop(); // stop fade out timer
                play.Visible = false; // hide play button
                play.Enabled = false; // disable play button
            }

            UpdateFadedImage(play, playOpacity); // update the image with current opacity
        }

        // update the image of a picture box with given opacity
        private void UpdateFadedImage(PictureBox pictureBox, float opacity)
        {
            Bitmap fadedBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

            using (Graphics g = Graphics.FromImage(fadedBitmap))
            {
                ColorMatrix matrix = new ColorMatrix { Matrix33 = opacity }; // adjust opacity
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix);

                g.DrawImage(pictureBox.Image, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height),
                    0, 0, pictureBox.Image.Width, pictureBox.Image.Height,
                    GraphicsUnit.Pixel, attributes);
            }

            pictureBox.Image = fadedBitmap; // set the faded image
        }

        // start the animation
        public void StartAnimation()
        {
            animationStep = 0; // reset animation step
            animationTimer.Start(); // start the animation timer
        }

        // handle fade-in effect on the buttons
        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            btnOpacity += FadeInStep; // increase opacity

            if (btnOpacity >= 1.0f)
            {
                btnOpacity = 1.0f;
                fadeInTimer.Stop(); // stop fade in when fully visible
            }

            btnEasy.Visible = btnHard.Visible = true; // make buttons visible
            btnEasy.Enabled = btnHard.Enabled = true; // enable buttons
        }

        // handle main animation steps
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            animationStep++; // increase animation step

            if (animationStep <= 30)
            {
                ShrinkLogo(); // shrink logo in the first steps
            }
            else if (animationStep <= 50)
            {
                if (!fadeInTimer.Enabled) fadeInTimer.Start(); // start fade-in for buttons
                SlideButtons(btnEasy, btnHard); // slide buttons up
            }
            else
            {
                animationTimer.Stop(); // stop the animation when done
            }
        }

        // shrink the logo size
        private void ShrinkLogo()
        {
            int shrinkAmountWidth = 20;
            int shrinkAmountHeight = 10;

            int newWidth = Math.Max(logo.Width - shrinkAmountWidth, 5);
            int newHeight = Math.Max(logo.Height - shrinkAmountHeight, 5);

            int deltaX = (logo.Width - newWidth) / 2;
            int deltaY = (logo.Height - newHeight) / 2;

            logo.Width = newWidth;
            logo.Height = newHeight;
            logo.Left += deltaX; // move logo horizontally to center
            logo.Top += deltaY - 10; // move logo vertically
            logo.Invalidate(); // force a repaint
        }

        // slide buttons up
        private void SlideButtons(params PictureBox[] buttons)
        {
            foreach (var button in buttons)
            {
                button.Top -= SlideSpeed; // move buttons up by slidespeed
            }
        }

        // get the center position of a control
        private Point GetCenteredPosition(Control control)
        {
            return new Point(control.Left + control.Width / 2, control.Top + control.Height / 2);
        }

        // center a control at the given position
        private void CenterControl(Control control, Point center)
        {
            control.Left = center.X - control.Width / 2;
            control.Top = center.Y - control.Height / 2;
        }
    }
}
