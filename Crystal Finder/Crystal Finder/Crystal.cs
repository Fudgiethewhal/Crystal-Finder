using System;
using System.Collections.Generic;

namespace Crystal_Finder
{
    public class Crystal
    {
        public string Type { get; set; }
        public string Description { get; set; }

        private static readonly List<string> CrystalTypes = new List<string>
        {
            "Cubic", "Tetragonal", "Orthorhombic",
            "Monoclinic", "Triclinic", "Rhombohedral",
            "Hexagonal", "Not Sure"
        };

        public Crystal(string type, string description)
        {
            Type = type;
            Description = description;
        }

        public static Crystal CreateFromUserInput()
        {
            Console.WriteLine("Choose a type: ");
            for (int i = 0; i < CrystalTypes.Count; i++)
            {
                Console.WriteLine($"{i +1}. {CrystalTypes[i]}");
            }

            Console.Write("Enter your choice (1-8: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= CrystalTypes.Count)
            {
                string selectedType = CrystalTypes[choice - 1];
                Console.WriteLine($"You selected: {selectedType}");
                
                Console.Write("Enter your description of the crystal: ");
                string description = Console.ReadLine();
                
                return new Crystal(selectedType, description);
            }
            else
            {
                Console.WriteLine("Invalid choice. No crystal found.");
                return null;
            }
        }
    }
}