using System;
using System.Collections.Generic;
using System.IO;

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

        private static readonly Dictionary<string, Room> RoomMap;

        static Program()
        {
            RoomMap = new Dictionary<string, Room>();

            foreach (Room room in Rooms)
            {
                RoomMap[room.Name] = room;
            }
        }

        private enum Fields
        {
            Name,
            Description
        }

        static void Main(string[] args)
        {
            string roomsFileName = "Rooms.txt";
            
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;

            Room previousRoom = null;
            InitializeRoomDescriptions(roomsFileName);

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

        private static void InitializeRoomDescriptions(string roomsFileName)
        {
            const string delimiter = "##";
            const int expectedFieldCount = 2;

            string[] lines = File.ReadAllLines(roomsFileName);

            foreach (string line in lines)
            {
                string[] fields = line.Split(delimiter);

                if (fields.Length != expectedFieldCount)
                {
                    throw new InvalidDataException("Invalid record.");
                }

                string name = fields[(int)Fields.Name];
                string description = fields[(int)Fields.Description];

                RoomMap[name].Description = description;
            }
        }

        private static (int locationRow, int locationColumn) Locate = (1, 1);
    }
}