using System;
using System.Collections.Generic;

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

            Room previousRoom = null;
            InitializeRoomDescriptions();

            bool displayLocationName = true;

            while (command != Commands.QUIT)
            {
                if (displayLocationName)
                {
                    Console.WriteLine(Location.Name);
                }

                if (previousRoom != Location)
                {
                    Console.WriteLine(Location.Description);
                    previousRoom = Location;
                }

                Console.Write("> ");

                //Take in commands and identify them as uppercase
                string inputString = Console.ReadLine();
                command = ToCommand(inputString.Trim().ToUpper());

                switch (command)
                {
                    case Commands.QUIT:
                        Console.WriteLine("Thank you for playing");
                        break;

                    case Commands.LOOK:
                        displayLocationName = false;

                        if (!displayLocationName)
                        {
                            Console.WriteLine(Location.Name);
                        }

                        Console.WriteLine(Location.Description);
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.WEST:
                    case Commands.EAST:
                        displayLocationName = true;

                        if (Move(command) == false)
                        {
                            Console.WriteLine("The way is shut!");
                        }
                        
                        break;

                    default:
                        Console.WriteLine("Unrecognized command.");
                        displayLocationName = true;
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
            var roomMap = new Dictionary<string, Room>();

            foreach (Room room in Rooms)
            {
                roomMap[room.Name] = room;
            }

            roomMap["Rocky Trail"].Description = "You are on a rock-strewn trail.";
            roomMap["South of House"].Description = "You are facing the south side of a white house. There is no door here, and all the windows are barred.";
            roomMap["Canyon View"].Description = "You are at the top of the Great Canyon on its south wall.";
           
            roomMap["Forest"].Description = "This is a forest, with trees in all directions around you.";
            roomMap["West of House"].Description = "This is an open field west of a white house, with a boarded front door.";
            roomMap["Behind House"].Description = "You are behind the white house. In one corner of the house there is a small window which is slightly ajar.";
        
            roomMap["Dense Woods"].Description = "This is a dimly lit forest, with large trees all around. To the east, there appears to be sunlight.";
            roomMap["North of House"].Description = "You are facing the north side of a white house. There is no door here, and all the windows are barred.";
            roomMap["Clearing"].Description = "You are in a clearing, with a forest surrounding you to the west and south.";
        }

        private static (int locationRow, int locationColumn) Locate = (1, 1);
    }
}