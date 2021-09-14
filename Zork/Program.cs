using System;
using System.Collections.Generic;

namespace Zork
{
    class Program
    {
        private static string CurrentLocation
        {
            get
            {
                return Rooms[Locate.row, Locate.column];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;

            while (command != Commands.QUIT)
            {
                Console.Write($"{CurrentLocation}\n> ");

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
                        outputString = Move(command) ? $"You moved {command}." : "The way is shut!";
                        break;

                    default:
                        outputString = "Unrecognized command.";
                        break;
                }

                Console.WriteLine(outputString);
            }
        }

        private static bool Move(Commands command)
        {
            Assert.IsTrue(IsDirection(command), "Invalid direction.");
            bool didMove = false;

            switch (command)
            {
                case Commands.NORTH when Locate.row < Rooms.GetLength(0) - 1:
                    Locate.row++;
                    didMove = true;
                    break;

                case Commands.SOUTH when Locate.row > 0:
                    Locate.row--;
                    didMove = true;
                    break;

                case Commands.WEST when Locate.column > 0:
                    Locate.column--;
                    didMove = true;
                    break;

                case Commands.EAST when Locate.column < Rooms.GetLength(1) - 1:
                    Locate.column++;
                    didMove = true;
                    break;
            }

            return didMove;
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

        private static bool IsDirection(Commands command) => Directions.Contains(command);

        private static readonly string[,] Rooms =
        {
            { "Rocky Trail", "South of House", "Canyon View" },
            { "Forest", "West of House", "Behind House" },
            { "Dense Woods", "North of House", "Clearing" }
        };

        private static readonly List<Commands> Directions = new List<Commands>
        {
            Commands.NORTH,
            Commands.SOUTH,
            Commands.WEST,
            Commands.EAST
        };

        private static (int row, int column) Locate = (1, 1);
    }
}