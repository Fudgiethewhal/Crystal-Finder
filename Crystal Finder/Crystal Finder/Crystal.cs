namespace Crystal_Finder;

public class Crystal
{
    public string Type { get; set; }
    public string Description { get; set; }

    public Crystal(string type, string description)
    {
        Type = type;
        Description = description;
    }

    public override string ToString()
    {
        return $"{Type} - {Description}";
    }
}