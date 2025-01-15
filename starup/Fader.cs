using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace starup
{
    public class Fader
    {
        private readonly PictureBox pictureBox;  // PictureBox to fade
        private readonly Image originalImage;    // Store the original image of the PictureBox
        private float opacity = 0.0f;            // Initial opacity (completely transparent)
        private readonly Timer fadeInTimer;      // Timer to manage fading effect

        private const int FadeInterval = 10;     // Timer interval (in ms)
        private const float FadeInStep = 0.1f;  // Increase opacity by this amount per step

        // Constructor to initialize Fader for the given PictureBox
        public Fader(PictureBox pictureBox)
        {
            if (pictureBox == null)
                throw new ArgumentNullException(nameof(pictureBox), "PictureBox cannot be null.");
            if (pictureBox.Image == null)
                throw new ArgumentException("PictureBox must have an image set.", nameof(pictureBox));

            this.pictureBox = pictureBox;
            originalImage = pictureBox.Image;  // Store the original image

            // Initialize and configure the fade-in timer
            fadeInTimer = new Timer { Interval = FadeInterval };
            fadeInTimer.Tick += FadeInTimer_Tick; // Event handler for timer ticks
        }

        // Method to start the fade-in process
        public void StartFadeIn()
        {
            opacity = 0.0f;                  // Start from fully transparent
            pictureBox.Visible = true;       // Ensure PictureBox is visible
            pictureBox.Image = null;         // Clear the image initially to avoid flicker
            fadeInTimer.Start();             // Start the fade-in timer
        }

        // Timer tick event handler to adjust opacity and update the image
        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            opacity += FadeInStep;           // Increase opacity step by step

            // If opacity reaches 1.0, stop the timer
            if (opacity >= 1.0f)
            {
                opacity = 1.0f;             // Ensure opacity doesn't exceed 1.0
                fadeInTimer.Stop();         // Stop the fade effect
            }

            // Update the PictureBox with the new faded image
            UpdateFadedImage();
        }

        // Method to update the PictureBox with the current faded image
        private void UpdateFadedImage()
        {
            Bitmap fadedBitmap = new Bitmap(originalImage.Width, originalImage.Height); // Create a new bitmap for the faded image

            using (Graphics g = Graphics.FromImage(fadedBitmap))
            {
                g.Clear(Color.Transparent);    // Clear background to transparent

                ColorMatrix matrix = new ColorMatrix
                {
                    Matrix33 = opacity           // Set opacity value in the color matrix
                };

                using (ImageAttributes attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(matrix); // Apply opacity to image

                    // Draw the original image with the new opacity on the faded bitmap
                    g.DrawImage(originalImage,
                        new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                        0, 0, originalImage.Width, originalImage.Height,
                        GraphicsUnit.Pixel, attributes);
                }
            }

            pictureBox.Image = fadedBitmap;    // Update the PictureBox's image with the faded one
        }
    }
}
