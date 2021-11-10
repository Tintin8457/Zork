using System;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultZorkFileName = "Zork.json";
            string gameFileName = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultZorkFileName);

            ConsoleInputService input = new ConsoleInputService();
            ConsoleOuputService output = new ConsoleOuputService();

            //Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(gameFileName));
            
            Game game = Game.Load(gameFileName, output);
            game.Player.LocationChanged += Player_LocationChanged;

            //Console.WriteLine("Welcome to Zork!");
            game.Run(output, input);
            //Console.WriteLine("Thank you for playing!");

            Room previousRoom = null;

            while (game.IsRunning)
            {
                output.WriteLine(game.Player.Location);

                if (previousRoom != game.Player.Location)
                {
                    previousRoom = game.Player.Location;
                }

                output.Write("\n> ");
                input.ProcessInput();
            }
        }

        private static void Player_LocationChanged(object sender, Room e)
        {
            System.Console.WriteLine($"You moved to {e.Name}");
            throw new NotImplementedException();
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}
