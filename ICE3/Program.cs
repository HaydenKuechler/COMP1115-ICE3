using System.Collections;

namespace ICE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Min and Max Veriables
            int Min = 0;
            int Max = 50;
            bool CorrectValue = false;
            //Primary Attributes
            int Agility;
            int Strength;
            int Vigor;
            int Perception;
            int Intellect;
            int Will;
            //Secondary Attributes 
            int Awareness = 0;
            int Toughness = 0;
            int Resolve = 0;
            //Career Variables + Strings
            var CharacterName = "Unkown";
            string Career = "Unknown";
            int CareerChoice = 0;
            bool HasChosenCareer = false;
            //Background Colour 
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            // Foreground colour 
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            //Title Page
            Console.Title = ("Character Sheet");
            // Propt for Charcter Name
            Console.Write("Please enter your players name");
            CharacterName = Console.ReadLine();
            Console.Clear();
            //Select your Career
            Console.WriteLine(" Select a Number to go along with your Career");
            Console.WriteLine("1 Army AGL 35, STR 40, VGR 35, PER 25, INT, 35 Wil 30)");
            Console.WriteLine("2 Psion AGL 25, STR 25, VGR 40, PER 35, INT, 35 Wil 30)");
            Console.WriteLine("3 Rouge AGL 30, STR 25, VGR 30, PER 20, INT, 25 Wil 30)");
            Console.WriteLine("4 Telepath AGL 30, STR 25, VGR 25, PER 30, INT, 40 Wil 30)");
            Console.WriteLine("5 Tinker AGL 25, STR 30, VGR 25, PER 30, INT, 30 Wil 25)");
            Console.WriteLine("6 Assassain AGL 45, STR 25, VGR 25, PER 35, INT, 35 Wil 25)");
            Console.WriteLine("7 Random");
            CareerChoice = Convert.ToInt32(Console.ReadLine());
           //Choices and their stats
            if (CareerChoice == 1)
            {
                Career = "Army";
                Agility = 35;
                Strength = 40;
                Vigor = 35;
                Perception = 25;
                Intellect = 35;
                Will = 30;
                Console.WriteLine("Welcome to camp Solider!");
            }
            else if (CareerChoice == 2)
            {
                Career = "Psion";
                Agility = 25;
                Strength = 25;
                Vigor = 40;
                Perception = 35;
                Intellect = 35;
                Will = 30;
                Console.WriteLine("ahh one with the Psycics");
            }

            else if (CareerChoice == 3)
            {
                Career = "Rouge";
                Agility = 30;
                Strength = 25;
                Vigor = 30;
                Perception = 20;
                Intellect = 35;
                Will = 30;
                Console.WriteLine("You don't listen to others well");
            }
            else if (CareerChoice == 4)
            {
                Career = "Telepath";
                Agility = 30;
                Strength = 25;
                Vigor = 25;
                Perception = 30;
                Intellect = 40;
                Will = 30;
                Console.WriteLine("A mind reader you say");
            }
            else if (CareerChoice == 5)
            {
                Career = "Tinker";
                Agility = 25;
                Strength = 30;
                Vigor = 25;
                Perception = 30;
                Intellect = 30;
                Will = 25;
                Console.WriteLine("Lets get to work");
            }
            else if (CareerChoice == 2)
            {
                Career = "Assassin";
                Agility = 45;
                Strength = 25;
                Vigor = 25;
                Perception = 35;
                Intellect = 35;
                Will = 25;
                Console.WriteLine("Cold but Calculated");
                //Calculate Secondary Attributes 
                Awareness = Agility + Perception;
                Toughness = Strength + Vigor;
                Resolve = Intellect + Will;
                //If no player is selected error will apear
                if (HasChosenCareer = false) ;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error, Wrong Imputs for Career");

                
            }
           


            
            

            /*
            if (CharacterName == "Hayden")
            
                Console.WriteLine("Welcome Hayden");


            
            //Second Test for possible name  
            else if (CharacterName == "Bob")
            
                Console.WriteLine(" Welcome Bob");
            
            //Triggers if all other texts fail 
            else
            
                Console.WriteLine("Some Other name was entered");


           
              // another way of seeing if staemnets are true using "Or"
            /*
             * if((Agility<5 || (Agility >50))
             * if((agility >= Min) && (Agility <= max))
             */



        }
    }
}
