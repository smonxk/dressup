using System;
using System.Drawing;
using System.Windows.Forms;

namespace starup
{
    public static class ImageFinder
    {
        // ,ethod to get the image by character and item name
        public static Image GetImageByName(string characterName, string itemName)
        {
            switch (characterName)
            {
                case "Inerys":
                    return GetInerysImage(itemName);
                case "Loraina":
                    return GetLorainaImage(itemName);
                default:
                    return null;
            }
        }

        // images for Inerys
        private static Image GetInerysImage(string itemName)
        {
            switch (itemName)
            {
                case "pjTopBtn":
                    return Properties.Resources.inePjTop;
                case "pjBottomBtn":
                    return Properties.Resources.inePjBot;
                case "pjShoesBtn":
                    return Properties.Resources.InePjShoes;
                case "blueHairpinBtn":
                    return Properties.Resources.ineHairpinBlue;
                default:
                    return null;
            }
        }

        // images for Loraina
        private static Image GetLorainaImage(string itemName)
        {
            switch (itemName)
            {
                case "comfyDressBtn":
                    return Properties.Resources.lorDress;
                case "brownBeltBtn":
                    return Properties.Resources.lorBelt;
                case "whiteSocksBtn":
                    return Properties.Resources.lorSocksWhite;
                default:
                    return null;
            }
        }
    }
}
