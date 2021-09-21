﻿using System;

namespace Zork
{
    class Program
    {
        private static Room Location
        {
            get
            {
                return Rooms[Locate.locationRow, Locate.locationColumn];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;

            InitializeRoomDescriptions();

            while (command != Commands.QUIT)
            {
                Console.Write($"{Location}\n> ");

                //Take in commands and identify them as uppercase
                string inputString = Console.ReadLine();
                command = ToCommand(inputString.Trim().ToUpper());

                switch (command)
                {
                    case Commands.QUIT:
                        Console.WriteLine("Thank you for playing");
                        break;

                    case Commands.LOOK:
                        Console.WriteLine(Location.Description);
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.WEST:
                    case Commands.EAST:
                        Console.WriteLine(Move(command) ? $"You moved {command}." : "The way is shut!");
                        break;

                    default:
                        Console.WriteLine("Unrecognized command.");
                        break;
                }
            }
        }

        private static bool Move(Commands command)
        {
            bool didMove = false;

            switch (command)
            {
                case Commands.NORTH when Locate.locationRow < Rooms.GetLength(1) - 1:
                    Locate.locationRow++;
                    didMove = true;
                    break;

                case Commands.SOUTH when Locate.locationRow > 0:
                    Locate.locationRow--;
                    didMove = true;
                    break;

                case Commands.WEST when Locate.locationColumn > 0:
                    Locate.locationColumn--;
                    didMove = true;
                    break;

                case Commands.EAST when Locate.locationColumn < Rooms.GetLength(1) - 1:
                    Locate.locationColumn++;
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


        private static readonly Room[,] Rooms =
        {
            { new Room("Rocky Trail"), new Room("South of House"), new Room("Canyon View") },
            { new Room("Forest"), new Room("West of House"), new Room("Behind House") },
            { new Room("Dense Woods"), new Room("North of House"), new Room("Clearing") }
        };

        private static void InitializeRoomDescriptions()
        {
            Rooms[0, 0].Description = "You are on a rock-strewn trail.";
            Rooms[0, 1].Description = "You are facing the south side of a white house. There is no door here, and all the windows are barred.";
            Rooms[0, 2].Description = "You are at the top of the Great Canyon on its south wall.";

            Rooms[1, 0].Description = "This is a forest, with trees in all directions around you.";
            Rooms[1, 1].Description = "This is an open field west of a white house, with a boarded front door.";
            Rooms[1, 2].Description = "You are behind the white house. In one corner of the house there is a small window which is slightly ajar.";

            Rooms[2, 0].Description = "This is a dimly lit forest, with large trees all around. To the east, there appears to be sunlight.";
            Rooms[2, 1].Description = "You are facing the north side of a white house. There is no door here, and all the windows are barred.";
            Rooms[2, 2].Description = "You are in a clearing, with a forest surrounding you to the west and south.";
        }

        private static (int locationRow, int locationColumn) Locate = (1, 1);
    }
}