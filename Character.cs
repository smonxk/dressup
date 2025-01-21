public class Character
{
    // property to store the character's name and description
    public string Name { get; set; }
    public string Description { get; set; }

    // default constructor for XML deserialization (used when loading data from XML)
    public Character() { }
}
