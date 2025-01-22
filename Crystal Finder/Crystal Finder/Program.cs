using System;
using System.Collections.Generic;
using Crystal_Finder;

class Program
{
    static void Main()
    { 
        Dictionary<string, List<string>> crystalsCollection = new Dictionary<string, List<string>>();
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
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    static void AddCrystals(Dictionary<string, List<string>> collection)
    {
        Console.WriteLine("Enter Location:");
        string location = Console.ReadLine();
        
        Console.WriteLine("Enter crystal: ");
        string crystal = Console.ReadLine();

        if (!collection.ContainsKey(location))
        {
            collection[location] = new List<string>();
        }
        
        collection[location].Add(crystal);
        Console.WriteLine($"Added {crystal} to {location}!");
    }

    static void ViewCollection(Dictionary<string, List<string>> collection)
    {
        Console.WriteLine("\nCrystal Collection:");

        if (collection.Count == 0)
        {
            Console.WriteLine("No crystal found!");
            return;
        }

        foreach (var location in collection)
        {
            Console.WriteLine($"Location: {location.Key}");
            Console.WriteLine($"Crystals: " + string.Join(", ", location.Value));
        }
    }
}