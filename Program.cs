using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

public class ClothingItem
{
    public string Name { get; set; }
    public List<string> Styles { get; set; } = new List<string>();
    public List<string> Colors { get; set; }= new List<string>();
    public int Warmth { get; set; } // 1-35, 1 is for winter fits, 35 is for summer fits

    public ClothingItem(string name, List<string> styles, List<string> colors, int warmth)
    {
        Name = name;
        Styles = styles;
        Colors = colors;
        Warmth = warmth;
    }

}

public class Outfit
{
    public List<ClothingItem> Items { get; set; } = new List<ClothingItem>();

    public double CalculateAverageWarmth()
    {
        return Items.Average(item => item.Warmth);
    }

    public int PointsForFit(Character character)
    {
        int points = 0;

        if (Items.Count == 0)
            {
            return points;
            }

        foreach (var item in Items)
        {
            foreach (var style in item.Styles)
            {
                if (character.Preferences.LikedStyles.ContainsKey(style))
                {
                    points += character.Preferences.LikedStyles[style];
                }
                else if (character.Preferences.DislikedStyles.ContainsKey(style))
                {
                    points -= character.Preferences.DislikedStyles[style];
                }
            }

            foreach (var color in item.Colors)
            {
                if (character.Preferences.LikedColors.ContainsKey(color))
                {
                    points += character.Preferences.LikedColors[color];
                }
                else if (character.Preferences.DislikedColors.ContainsKey(color))
                {
                    points -= character.Preferences.DislikedColors[color];
                }

            }
        }
        return points;
    }




    public class CharacterPreferences
    {
        public Dictionary<string, int> LikedStyles { get; set; } = new Dictionary<string, int>();
        public Dictionary<string, int> DislikedStyles { get; set; } = new Dictionary<string, int>();
        public Dictionary<string, int> LikedColors { get; set; } = new Dictionary<string, int>();
        public Dictionary<string, int> DislikedColors { get; set; } = new Dictionary<string, int>();

    }

    public class Character
    {
        public string Name { get; set; }
        public CharacterPreferences Preferences { get; set; }

        public string TooHotFeedback { get; set; }
        public string TooWarmFeedback { get; set; }
        public string TooColdFeedback { get; set; }
        public string TooChillyFeedback { get; set; }
        public string JustRightFeedback { get; set; }

        public Character(string name, CharacterPreferences preferences, string tooHotFeedback,
            string tooWarmFeedback, string tooColdFeedback, string tooChillyFeedback,
            string justRightFeedback)
        {
            Name = name;
            Preferences = preferences;
            //add description path here?

            TooHotFeedback = tooHotFeedback;
            TooWarmFeedback = tooWarmFeedback;
            TooColdFeedback = tooColdFeedback;
            TooChillyFeedback = tooChillyFeedback;
            JustRightFeedback = justRightFeedback;
        }


        public string EvaluateWarmthFit(double warmthDifference)
        {
            if (Math.Abs(warmthDifference) <= 1)
            {
                return JustRightFeedback;
            }
            else if (Math.Abs(warmthDifference) <= 3)
            {
                if (warmthDifference > 0)
                    return TooWarmFeedback;
                else
                    return TooChillyFeedback;
            }
            else
            {
                if (warmthDifference > 0)
                    return TooHotFeedback;
                else
                    return TooColdFeedback;
            }
        }
    }

    public class Game
    {

       
    }
}