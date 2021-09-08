using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;

            while (command != Commands.QUIT)
            {
                Console.Write("> ");

                //Take in commands and identify them as uppercase
                string inputString = Console.ReadLine();
                command = ToCommand(inputString.Trim().ToUpper());

                string outputString;

                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing";
                        break;

                    case Commands.LOOK:
                        outputString = "This is an open field west of a white house, with a boarded front door.\nA rubber mat saying 'Welcome to Zork'";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.WEST:
                    case Commands.EAST:
                        outputString = $"You moved {command}.";
                        break;

                    default:
                        outputString = "Unrecognized command.";
                        break;
                }

                Console.WriteLine(outputString);
            }
        }

    private static Commands ToCommand(string commandString)
        {
            try
            {
                return Enum.Parse<Commands>(commandString);
            }

            catch
            {
                return Commands.UNKNOWN;
            }
        }
    }
}
