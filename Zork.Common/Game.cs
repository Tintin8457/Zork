using System;
using System.IO;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace Zork
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public World World { get; set; }

        public IOutputService Output { get; set; }
        public IInputService Input { get; set; }

        public string StartingLocation { get; set; }
        public string WelcomeMessage { get; set; }
        public string ExitMessage { get; set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        public bool IsRunning { get; set; }

        [JsonIgnore]
        public Dictionary<string, Commands> Commands { get; private set; }

        public Game (World mWorld, Player mPlayer)
        {
            World = mWorld;
            Player = mPlayer;

            Commands = new Dictionary<string, Commands>()
            {
                { "QUIT", new Commands("QUIT", new string[] { "QUIT", "Q", "BYE" }, Quit) },
                { "LOOK", new Commands("LOOK", new string[] { "LOOK", "L" }, Look) },
                { "NORTH", new Commands("NORTH", new string[] { "NORTH", "N" }, game => Move(game, Directions.North)) },
                { "SOUTH", new Commands("SOUTH", new string[] { "SOUTH", "S" }, game => Move(game, Directions.South)) },
                { "EAST", new Commands("EAST", new string[] { "EAST", "E"}, game => Move(game, Directions.East)) },
                { "WEST", new Commands("WEST", new string[] { "WEST", "W" }, game => Move(game, Directions.West)) },
            };
        }

        public int playerScore = 0;
        public int playerMoves = 0;

        public void Run(IInputService input, IOutputService output)
        {
            Assert.IsNotNull(output);
            Output = output;

            Assert.IsNotNull(input);
            Input = input;

            Input.InputReceived += InputReceivedHandler;

            Output.WriteLine(string.IsNullOrWhiteSpace(WelcomeMessage) ? "Welcome to Zork!" : WelcomeMessage);
            IsRunning = true;

            Room previousRoom = null;

            while (IsRunning)
            {
                Console.WriteLine(Player.Location);
                if (previousRoom != Player.Location)
                {
                    Look(this);
                    previousRoom = Player.Location;
                }

                Console.Write("\n> ");
                string commandString = Console.ReadLine().Trim().ToUpper();
                Commands foundCommand = null;
                foreach (Commands command in Commands.Values)
                {
                    if (command.Verbs.Contains(commandString))
                    {
                        foundCommand = command;
                        break;
                    }
                }

                if (foundCommand != null)
                {
                    foundCommand.Action(this);
                }

                else
                {
                    Console.WriteLine("Unknown command.");
                }
            }

            Console.WriteLine(string.IsNullOrWhiteSpace(ExitMessage) ? "Thank you for playing!" : ExitMessage);
        }
    

        private void InputReceivedHandler(object sender, string commandString)
        {
            Commands foundCommand = null;

            //foreach(Commands command in Commands.Values)
            //{
            //    if(command.Verbs.Contains(commandString))
            //    {
            //        foundCommand = command;
            //        break;
            //    }

            //    if(foundCommand != null)
            //    {
            //        foundCommand.Action(this);
            //    }

            //    else
            //    {
            //        Output.WriteLine("Unknown command.");
            //    }
            //} 
        }

        private static void Move(Game game, Directions direction)
        {
            if (game.Player.Move(direction) == false)
            {
                game.Output.WriteLine("The way is shut!");
            }
        }

        public static void Look(Game game) => game.Output.WriteLine(game.Player.Location.Description);
        private static void Quit(Game game) => game.IsRunning = false;

        public static Game Load(string filename, IOutputService output)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(filename));
            game.Player = game.World.SpawnPlayer();
            game.Output = output;
            
            return game;
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context) => Player = new Player(World, StartingLocation);

    }
}
