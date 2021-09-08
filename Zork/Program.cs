﻿using System;

namespace Zork
{
    class Program
    {
        private static string Location
        {
            get
            {
                return Rooms[locationColumn];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;

            while (command != Commands.QUIT)
            {
                Console.Write($"{Location}\n> ");

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
            bool didMove = false;

            switch (command)
            {
                case Commands.NORTH:
                case Commands.SOUTH:
                    break;

                case Commands.WEST when locationColumn > 0:
                    locationColumn--;
                    didMove = true;
                    break;

                case Commands.EAST when locationColumn < Rooms.Length - 1:
                    locationColumn++;
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

        private static string[] Rooms = { "Forest", "West of House", "Behind House", "Clearing", "Canyon View"};
        private static int locationColumn = 1;
    }
}
