namespace Crystal_Finder;

public class Crystal
{
    public string Type { get; set; }
    public string Description { get; set; }

    public Crystal(string type, string description)
    {
        Type = type;
        Description = description;

        switch (choice)
        { 
            Console.WriteLine("1.Is this a Cubic crystal?");
            Console.WriteLine("2. Is this a Tetragonal crystal?");
            Console.WriteLine("3. Is this a Orthohombical crystal?");
            Console.WriteLine("4. Is this a Monoclinic crystal?");
            Console.WriteLine("5. Is this a Triclinic crystal?");
            Console.WriteLine("6. Is this a Rhombohedral crystal?");
            Console.WriteLine("7. Is this a Hexagonal crystal?");
            Console.WriteLine("8. Not sure? No problem, you can record at a later time.");
            Console.Write("9. Exit");
           

            string input = Console.ReadLine();
        }

    }

    public override string ToString()
    {
        return $"{Type} - {Description}";
    }
}