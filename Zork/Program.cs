using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    class Program
    {
        /*public static Room Location
        {
            get
            {
                return Rooms[Locate.locationRow, Locate.locationColumn];
            }
        }*/

        /*private enum Fields
        {
            Name,
            Description
        }*/

        /*public enum Directions
        {
            North,
            South,
            East,
            West
        }*/

        static void Main(string[] args)
        {
            const string defaultZorkFileName = "Zork.json";
            string gameFileName = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultZorkFileName);

            Game game = Game.Load(gameFileName);
            Console.WriteLine("Welcome to Zork!");
            game.Run();
            Console.WriteLine("Thank you for playing!");

            //Room previousRoom = null;
            //Commands command = Commands.UNKNOWN;

        //InitializeRooms(roomsFileName);

        //bool displayLocationName = true;

        /*while (command != Commands.QUIT)
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
        }*/
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }

        /*private static bool Move(Commands command)
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
        }*/

        /*private static Commands ToCommand(string commandString)
        {
            try
            {
                return Enum.Parse<Commands>(commandString);
            }

            catch
            {
                return Commands.UNKNOWN;
            }
        }*/

        /*private static Room[,] Rooms;*/

        /*private static void InitializeRooms(string roomsFileName) =>
            Rooms = JsonConvert.DeserializeObject<Room[,]>(File.ReadAllText(roomsFileName));*/

        //private static (int locationRow, int locationColumn) Locate = (1, 1);
    }
}
