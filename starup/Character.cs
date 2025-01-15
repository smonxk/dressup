public class Character
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Character(string name, string description)
    {
        Name = name;
        Description = description;
    }

    // Default constructor for XML deserialization
    public Character() { }
}
