using System;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    public class Game
    {
        public World World { get; set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        public bool IsRunning { get; set; }

        public Game (World mWorld, Player mPlayer)
        {
            World = mWorld;
            Player = mPlayer;
        }

        public int playerScore = 0;
        public int playerMoves = 0;

        public void Run()
        {
            IsRunning = true;
            Room previousRoom = null;

            while (IsRunning)
            {
                Console.WriteLine(Player.Location);

                if (previousRoom != Player.Location)
                {
                    Console.WriteLine(Player.Location.Description);
                    previousRoom = Player.Location;
                }

                Console.Write("\n> ");
                Commands command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        IsRunning = false;
                        break;

                    case Commands.LOOK:
                        Console.WriteLine(Player.Location.Description);
                        playerMoves++;
                        break;

                    case Commands.SCORE:
                        Console.WriteLine("Your score would be " + playerScore + " in " + playerMoves + " moves.");
                        playerMoves++;
                        break;

                    case Commands.REWARD:
                        playerScore++;
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = Enum.Parse<Directions>(command.ToString(), true);
                        playerMoves++;

                        if (Player.Move(direction) == false)
                        {
                            Console.WriteLine("The way is shut!");
                            playerMoves++;
                        }

                        break;

                    default:
                        Console.WriteLine("Unknown Command.");
                        break;
                }
            }
        }

        public static Game Load(string filename)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(filename));
            game.Player = game.World.SpawnPlayer();
            
            return game;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result: Commands.UNKNOWN;
    }
}
