namespace Crystal_Finder;

public class CrystalManager
{
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