namespace Crystal_Finder
{
    public class Crystal
    {
        public string Type { get; set; }
        public string Description { get; set; }
        
        //"Readonly" is a list that cannot be reassigned after its initial assignment
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

        //returns a crystal object created based on user input
        public static Crystal CreateFromUserInput()
        {
            Console.WriteLine("Choose a type: ");
            //loops through each type in the CrystalTypes list
            for (int i = 0; i < CrystalTypes.Count; i++)
            {
                //Displays each crystal type as a numbered option starting from 1.
                Console.WriteLine($"{i +1}. {CrystalTypes[i]}");
            }

            //User will inout their response
            Console.Write("Enter your choice (1-8: ");
            string input = Console.ReadLine(); //will read the user's input as a string
            
            //tries to convert the input string into an integer, if successful
            //the integer is stored in choice
            //returns false if the input is invalid
            //ensures the choice is within the valid range of crystal types
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= CrystalTypes.Count)
            {
                //gets the selected crystal type from the list
                string selectedType = CrystalTypes[choice - 1];
                Console.WriteLine($"You selected: {selectedType}");//will display on the console.
                
                //will ask the user to describe crystal
                Console.Write("Enter your description of the crystal: ");
                string description = Console.ReadLine();
                
                //creates and returns a new crystal object using 
                //the selected type and user-provided description
                return new Crystal(selectedType, description);
            }
            else //This will occur when the input is invalid
            {
                Console.WriteLine("Invalid choice. No crystal found.");
                return null;
            }
        }
    }
}