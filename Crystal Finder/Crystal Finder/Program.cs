using System;
using System.Collections.Generic;
using Crystal_Finder;

class Program
{
    private static readonly List<string> CrystalTypes = new List<string>
    {
        "Cubic",
        "Tetragonal",
        "Orthorhombic",
        "Monoclinic",
        "Triclinic",
        "Rhombohedral",
        "Hexagonal",
        "Not Sure?"
    };
    static void Main()
    { 
        Dictionary<string, List<Crystal>> crystalsCollection = new Dictionary<string, List<Crystal>>();
        CrystalManager crystalManager = new CrystalManager();

        while (true)
        {
            Console.WriteLine("\nCrystal Collection Tracker");
            Console.WriteLine("1. Add Crystals");
            Console.WriteLine("2. View Collection");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddCrystals(crystalsCollection);
                    break;
                case "2":
                    ViewCollection(crystalsCollection);
                    break;
                case "3":
                    Console.WriteLine("Exit");
                    return;
                default:
                    Console.WriteLine("Enter your choice: ");
                    break;
            }
        }
    }

    static void AddCrystals(Dictionary<string, List<Crystal>> collection)
    {
        Console.WriteLine("Enter Location:");
        string location = Console.ReadLine();
        
        Console.WriteLine("Enter crystal type: ");
        for (int i = 0; i < CrystalTypes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {CrystalTypes[i]}");
        }

        Console.Write("Choose option: ");
        if (!int.TryParse(Console.ReadLine(), out int choice) || choice <= 0 || choice > CrystalTypes.Count)
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        string type = CrystalTypes[choice - 1];
        
        Console.WriteLine("Enter description: ");
        string description = Console.ReadLine();
        
        Crystal crystal = new Crystal(type, description);

        if (!collection.ContainsKey(location))
        {
            collection.Add(location, new List<Crystal>());
        }
        
        collection[location].Add(crystal);
        Console.WriteLine($"Added {crystal} to collection with a description of {description}, which is a type of {type}.");
    }

    static void ViewCollection(Dictionary<string, List<Crystal>> collection)
    {
        Console.WriteLine("\nCrystal Collection:");
        if (collection.Count == 0)
        {
            Console.WriteLine("No crystals collected yet!");
            return;
        }

        foreach (var location in collection)
        {
            Console.WriteLine($"Location: {location.Key}");
            foreach (var crystal in location.Value)
            {
                Console.WriteLine($" - {crystal}");
            }
        }
    }
}