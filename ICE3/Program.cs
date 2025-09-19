namespace ICE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "Character Sheet";
            String CharacterName;
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
            //Career Variables 
            int Army;
            int Psion;
            int Rouge;
            int Telepath;
            int Tinker;
           //Prompt Character name 
            Console.WriteLine("Please Enter your Name");
            string? CharcterName = Console.ReadLine();
            CharacterName = Console.ReadLine();
            
            
            /*
             * //Prompt for Agility
            Console.WriteLine("enter Agility");
            Agility = Convert. ToInt32(Console.ReadLine());

            if (Agility < 5)
            {
                Console.WriteLine("Number entered was too low");
            }
            else if (Agility > 50)
            { Console.WriteLine("Number entered was too high");
            }
            else
            {
                Console.WriteLine($"Your Agility is: {Agility}");
            }
           */ 


            /*
            if (CharacterName == "Hayden")
            {
                Console.WriteLine("Welcome Hayden");


            }
            //Second Test for possible name  
            else if (CharacterName == "Bob")
            {
                Console.WriteLine(" Welcome Bob");
            }
            //Triggers if all other texts fail 
            else
            {
                Console.WriteLine("Some Other name was entered");


            }
            
            */


        }
    }
}
