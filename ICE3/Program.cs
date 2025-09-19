namespace ICE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "Character Sheet";
            String Character;

            //Primary Attributes 
            int Agility;
            int Strength;
            int Vigor;
            int Perception;
            int Intellect;
            int Will;
            //Secondary Atributes 
            int Awareness;
            int toughness;
            int resolve;
            //Prompt Character name 
            Console.WriteLine("Please Enter your Name");
            string? CharcterName = Console.ReadLine();
            Character = Console.ReadLine();
            if (Character == "Hayden")
            {
                Console.WriteLine("Welcome Hayden");


            }
            



        }
    }
}
