using System;

namespace AgeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greeting the user and asking for their name
            Console.WriteLine("Tere!");
            Console.WriteLine("Mis on Sinu nimi?");
            string name = Console.ReadLine();
            
            // Asking the user when they were born
            Console.WriteLine("Tere, " + name);
            Console.WriteLine("Mis aastal sa sündisid?");
            string dobUserInput = Console.ReadLine();
            
            // Converting user input into an int
            int dobInt;
            dobInt = Int32.Parse(dobUserInput);

            // Calculations
            int dobCalculated = 2020 - dobInt;

            // Printing out the users age
            Console.WriteLine(name + ", sa oled: " + dobCalculated + " aastat vana.");

        }
    }
}