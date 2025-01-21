using static System.Windows.Forms.DataFormats;

public class ClothingItemManagement
{
    public Image CurrentTopImage { get; private set; }
    public Image CurrentBottomImage { get; private set; }
    public Image CurrentShoesImage { get; private set; }
    public Image CurrentAccessoriesImage { get; private set; }

    public void ToggleItem(PictureBox clickedBox, Func<string, Image> imageFinder, Form currentForm)
    {
        var boxTag = clickedBox.Tag?.ToString();  // getting the tag to determine which layer of painting panel will be updated

        // also getting forms tag so we can get the right backcolor for clicked items
        string formTag = currentForm.Tag?.ToString();

        switch (boxTag)
        {
            case "itemTop":
                CurrentTopImage = ToggleImage(CurrentTopImage, clickedBox, imageFinder(clickedBox.Name), formTag); 
                break;
            case "itemBottom":
                CurrentBottomImage = ToggleImage(CurrentBottomImage, clickedBox, imageFinder(clickedBox.Name), formTag);
                break;
            case "itemShoes":
                CurrentShoesImage = ToggleImage(CurrentShoesImage, clickedBox, imageFinder(clickedBox.Name), formTag);
                break;
            case "itemAcc":
                CurrentAccessoriesImage = ToggleImage(CurrentAccessoriesImage, clickedBox, imageFinder(clickedBox.Name), formTag);
                break;
        }
    }



    private Image ToggleImage(Image currentImage, PictureBox clickedBox, Image newImage, string formTag)
    {
        //dDetermines the color based on the form's tag
        Color highlightColor;
        if (formTag == "Inerys")
        {
            highlightColor = Color.FromArgb(235, 89, 103);  
        }
        else
        {
            highlightColor = Color.FromArgb(60, 150, 170);  // lorraina
        }

        if (currentImage == null)
        {
            clickedBox.BackColor = highlightColor; 
            return newImage;
        }
        else
        {
            clickedBox.BackColor = Color.Transparent;  
            return null;
        }
    }

}
