using System;
using System.Collections.Generic;

namespace Crystal_Finder;

public class CrystalManager
{
    private List<string> CrystalTypes = new List<string>
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
        public void AddCrystals(Dictionary<string, List<string>> collection)
        {
            Console.Write("Enter location: ");
            string location = Console.ReadLine();

            Console.Write("Enter crystal type: ");
            string crystal = Console.ReadLine();

            if (!collection.ContainsKey(location))
            {
                collection[location] = new List<string>();
            }

            collection[location].Add(crystal);
            Console.WriteLine($"Added {crystal} to {location}.");
        }
}