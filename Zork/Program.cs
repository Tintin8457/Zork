using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            //Take in commands and identify them as uppercase
            string inputString = Console.ReadLine().ToUpper();

            //Check for look and quit commands
            if (inputString == "QUIT")
            {
                Console.WriteLine("Thank you for playing.");
            }

            else if (inputString == "LOOK")
            {
                Console.WriteLine("This is an open field west of a white house, with a boarded front door.\nA rubber mat saying 'Welcome to Zork!' lies by the door.");
            }

            else
            {
                Console.WriteLine("Unrecognized command.");
            }
        }
    }
}
