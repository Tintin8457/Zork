//using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    class GameObject { }

    internal class Program
    {
        static void Main(string[] args)
        {
            const string defaultZorkFileName = "Zork.json";
            string gameFileName = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultZorkFileName);

            Game game = JsonConvert.DeserializeObject<Game>(gameFileName);

            ConsoleInputService input = new ConsoleInputService();
            ConsoleOuputService output = new ConsoleOuputService();
            

            output.WriteLine(string.IsNullOrWhiteSpace(game.WelcomeMessage) ? "Welcome to Zork!" : game.WelcomeMessage);
            game.Run(input, output);

            Room previousRoom = null;

            while (game.IsRunning)
            {
                output.WriteLine(game.Player.Location);

                if (previousRoom != game.Player.Location)
                {
                    Game.Look(game);
                    previousRoom = game.Player.Location;
                }

                output.Write("\n> ");
                input.ProcessInput();
            }

            output.WriteLine(string.IsNullOrWhiteSpace(game.ExitMessage) ? "Thank you for playing!" : game.ExitMessage);
        }

        private static void Player_LocationChanged(object sender, Room e)
        {
            System.Console.WriteLine($"You moved to {e.Name}");
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}
