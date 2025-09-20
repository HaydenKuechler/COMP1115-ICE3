using System.Collections;
using System.ComponentModel.Design;
using System.Security.Cryptography;

{
    // Min and Max Veriables
    int Min = 0;
    int Max = 50;
    bool CorrectValue = false;
    //Primary Attributes
    int Agility = 0;
    int Strength = 0;
    int Vigor = 0;
    int Perception = 0;
    int Intellect = 0;
    int Will = 0;
    //Secondary Attributes 
    int Awareness = 0;
    int Toughness = 0;
    int Resolve = 0;
    //Career Variables + Strings
    string CharacterName = "Unkown";
    string Career = "Unknown";
    int CareerChoice = 0;
    bool HasChosenCareer = false;
    //Background Colour 
    Console.BackgroundColor = ConsoleColor.DarkGray;
    // Foreground colour 
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Clear();
    //Title Page
    Console.Title = ("Character Sheet");
    // Propt for Charcter Name
    Console.Write("Please enter your players name");
    CharacterName = Console.ReadLine();
    Console.Clear();
    //Select your Career
    Console.WriteLine(" Select a Number to go with your career");
    Console.WriteLine("1 Army AGL 35, STR 40, VGR 35, PER 25, INT, 35 Will 30)");
    Console.WriteLine("2 Psion AGL 25, STR 25, VGR 40, PER 35, INT, 35 Will 30)");
    Console.WriteLine("3 Rouge AGL 30, STR 25, VGR 30, PER 20, INT, 25 Will 30)");
    Console.WriteLine("4 Telepath AGL 30, STR 25, VGR 25, PER 30, INT, 40 Will 30)");
    Console.WriteLine("5 Tinker AGL 25, STR 30, VGR 25, PER 30, INT, 30 Will 25)");
    Console.WriteLine("6 Assassain AGL 45, STR 25, VGR 25, PER 35, INT, 35 Will 25)");
    Console.WriteLine("7 Random");
    CareerChoice = Convert.ToInt32(Console.ReadLine());
    //Added switch case to select career and assign attributes
    switch (CareerChoice)
    {
        case 1:
            Career = "Army";
            Agility = 35;
            Strength = 40;
            Vigor = 35;
            Perception = 25;
            Intellect = 35;
            Will = 30;
            HasChosenCareer = true;
            break;

        case 2:
            Career = "Psion";
            Agility = 25;
            Strength = 25;
            Vigor = 40;
            Perception = 35;
            Intellect = 35;
            Will = 30;
            HasChosenCareer = true;
            break;
        case 3:
            Career = "Rouge";
            Agility = 30;
            Strength = 25;
            Vigor = 30;
            Perception = 20;
            Intellect = 25;
            Will = 30;
            HasChosenCareer = true;
            break;
        case 4:
            Career = "Telepath";
            Agility = 30;
            Strength = 25;
            Vigor = 25;
            Perception = 30;
            Intellect = 40;
            Will = 30;
            HasChosenCareer = true;
            break;
        case 5:
            Career = "Tinker";
            Agility = 25;
            Strength = 30;
            Vigor = 25;
            Perception = 30;
            Intellect = 30;
            Will = 25;
            HasChosenCareer = true;
            break;
        case 6:
            Career = "Assassain";
            Agility = 45;
            Strength = 25;
            Vigor = 25;
            Perception = 35;
            Intellect = 35;
            Will = 25;
            HasChosenCareer = true;
            break;
        case 7:
            Career = "Random";
            Random rand = new Random();
            Agility = rand.Next(5, 51);
            Strength = rand.Next(5, 51);
            Vigor = rand.Next(5, 51);
            Perception = rand.Next(5, 51);
            Intellect = rand.Next(5, 51);
            Will = rand.Next(5, 51);
            HasChosenCareer = true;
            break;
        default:
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Choice, Please choose a career");
            break;
    }
    //Added If statement to check if a career has been chosen
    if (HasChosenCareer == true) Console.WriteLine("Welcome to the World Traveler");
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("---------------------------Character Stat Menu----------------------------");
    Console.WriteLine("--------------------------------------------------------------------------");
    Console.WriteLine("---------------------------" + CharacterName + "--------------------------");
    Console.WriteLine("Career" + "---------------" + Career + "----------------------------------");
    Console.WriteLine("Primary Attributes" + "---------------------------------------------------");
    Console.WriteLine("--------------------------------------------------------------------------");
    Console.WriteLine($"Agility----------------------={Agility}----------------------------------");
    Console.WriteLine($"Strength---------------------={Strength}---------------------------------");
    Console.WriteLine($"Vigor------------------------={Vigor}------------------------------------");
    Console.WriteLine($"Perception-------------------={Perception}-------------------------------");
    Console.WriteLine($"Intellect--------------------={Intellect}--------------------------------");
    Console.WriteLine($"Will-------------------------={Will}-------------------------------------");
    Console.WriteLine("--------------------------------------------------------------------------");
    Console.WriteLine("Secondary Attributes" + "-------------------------------------------------");
    Console.WriteLine("--------------------------------------------------------------------------");
    //Calculating Secondary Attributes
    Awareness = Perception + Intellect;
    Toughness = Vigor + Strength;
    Resolve = Will + Intellect;
    Console.WriteLine($"Awareness--------------------={Awareness}--------------------------------");
    Console.WriteLine($"Toughness--------------------={Toughness}--------------------------------");
    Console.WriteLine($"Resolve----------------------={Resolve}----------------------------------");
    Console.WriteLine("--------------------------------------------------------------------------");
    Console.WriteLine("Press Any Key to Continue" + "----------------------------------------------");
    Console.ReadKey(true);

}





