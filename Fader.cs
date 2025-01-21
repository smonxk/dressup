using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace starup
{
    public class Fader
    {
        private readonly PictureBox pictureBox;  
        private readonly Image originalImage;    // the original image of the PictureBox
        private float opacity = 0.0f;           
        private readonly Timer fadeInTimer;     

        private const int FadeInterval = 10;     // interval 
        private const float FadeInStep = 0.1f;  

        // constructor - initializes fader for a pbox
        public Fader(PictureBox pictureBox)
        {
            if (pictureBox == null)
                throw new ArgumentNullException(nameof(pictureBox), "PictureBox cannot be null.");
            if (pictureBox.Image == null)
                throw new ArgumentException("PictureBox must have an image set.", nameof(pictureBox));

            this.pictureBox = pictureBox;
            originalImage = pictureBox.Image;  

            // timer inicializace
            fadeInTimer = new Timer { Interval = FadeInterval };
            fadeInTimer.Tick += FadeInTimer_Tick;
        }

        public void StartFadeIn()
        {
            opacity = 0.0f;            
            pictureBox.Visible = true; 
            pictureBox.Image = null;         // to avoid flickering
            fadeInTimer.Start();            
        }

        // adjusts opacity and updates the image
        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            opacity += FadeInStep;           // increases opacity step by step

            // if opacity = 1.0, = stop the timer
            if (opacity >= 1.0f)
            {
                opacity = 1.0f;             
                fadeInTimer.Stop();        
            }

           
            UpdateFadedImage();
        }

        //  updates the PictureBox with the current faded image
        private void UpdateFadedImage()
        {
            Bitmap fadedBitmap = new Bitmap(originalImage.Width, originalImage.Height); // new bitmap for the faded image

            using (Graphics g = Graphics.FromImage(fadedBitmap))
            {
                g.Clear(Color.Transparent);    //  background to transparent 

                ColorMatrix matrix = new ColorMatrix
                {
                    Matrix33 = opacity           // sets opacity value in the color matrix
                };

                using (ImageAttributes attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(matrix); // Apply opacity to image

                    //  draws original image with the new opacity on the faded bitmap
                    g.DrawImage(originalImage,
                        new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                        0, 0, originalImage.Width, originalImage.Height,
                        GraphicsUnit.Pixel, attributes);
                }
            }

            pictureBox.Image = fadedBitmap;    // updates the pb's image with the faded one
        }
    }
}