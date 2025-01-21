namespace starup //rework after exam
{
    public static class PanelRenderingHelper
    {
        // resizes an image to fit within a specified width and height
        // aspect ratio is the same
        public static Size ResizeImageToFit(Image image, int maxWidth, int maxHeight)
        {
            float aspectRatio = (float)image.Width / image.Height;

            int newWidth = maxWidth;
            int newHeight = (int)(newWidth / aspectRatio);

            // if the new height exceeds the maximum allowed height -> adjusts the size again
            if (newHeight > maxHeight)
            {
                newHeight = maxHeight;
                newWidth = (int)(newHeight * aspectRatio);
            }

           
            return new Size(newWidth, newHeight);
        }

        // renders clothing items on the panel
        public static void RenderClothingItems(PaintEventArgs e, ClothingItemManagement clothingItemManagement, Image baseImage, Image hairImage)
        {
            var currentTopImage = clothingItemManagement.CurrentTopImage;
            var currentBottomImage = clothingItemManagement.CurrentBottomImage;
            var currentShoesImage = clothingItemManagement.CurrentShoesImage;
            var currentAccessoriesImage = clothingItemManagement.CurrentAccessoriesImage;

            // resizes the images while maintaining aspect ratio
            Size baseImageSize = ResizeImageToFit(baseImage, 498, 1001);
            Size hairImageSize = ResizeImageToFit(hairImage, 498, 1001);

            // ensures that the base image is drawn first (background)
            e.Graphics.DrawImage(baseImage, new Rectangle(0, 0, baseImageSize.Width, baseImageSize.Height));

            // draws the current "Bottoms" (jeans, skirts...) image (only if not null)
            if (currentBottomImage != null)
            {
                Size bottomImageSize = ResizeImageToFit(currentBottomImage, 498, 1001);
                e.Graphics.DrawImage(currentBottomImage, new Rectangle(0, 0, bottomImageSize.Width, bottomImageSize.Height));
            }

            // draws the current "Top" image (only if not null)
            if (currentTopImage != null)
            {
                Size topImageSize = ResizeImageToFit(currentTopImage, 498, 1001);
                e.Graphics.DrawImage(currentTopImage, new Rectangle(0, 0, topImageSize.Width, topImageSize.Height));
            }

            // draws the hair image (foreground)
            e.Graphics.DrawImage(hairImage, new Rectangle(0, 0, hairImageSize.Width, hairImageSize.Height));

            // draws the current accessories image (only if not null)
            if (currentAccessoriesImage != null)
            {
                Size hairpinImageSize = ResizeImageToFit(currentAccessoriesImage, 498, 1001);
                e.Graphics.DrawImage(currentAccessoriesImage, new Rectangle(0, 0, hairpinImageSize.Width, hairpinImageSize.Height));
            }

            // draws the current shoes image (only if not null)
            if (currentShoesImage != null)
            {
                Size shoesImageSize = ResizeImageToFit(currentShoesImage, 498, 1001);
                e.Graphics.DrawImage(currentShoesImage, new Rectangle(0, 0, shoesImageSize.Width, shoesImageSize.Height));
            }
        }
    }
}
