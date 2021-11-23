using System;
//using System.IO;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace Zork
{
    public class Game : INotifyPropertyChanged
    {
        public event EventHandler GameStarted;
        public event EventHandler GameStopped;

        public event PropertyChangedEventHandler PropertyChanged;
        public World World { get; set; }

        [JsonIgnore]
        public IOutputService Output { get; set; }

        [JsonIgnore]
        public IInputService Input { get; set; }

        public string StartingLocation { get; set; }
        public string WelcomeMessage { get; set; }
        public string ExitMessage { get; set; }

        [JsonIgnore]
        public static Game Instance { get; private set; }

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

        /////////////////////////////score and moves
        public int playerScore = 0;
        public int playerMoves = 0;

        //public static void StartFromFile(string gameFileName, IOutputService output)
        //{
        //    if (!File.Exists(gameFileName))
        //    {
        //        throw new FileNotFoundException("Expected file.", gameFileName);
        //    }

        //    Run(File.ReadAllText(gameFileName), output);
        //}

        public void Run(IInputService input, IOutputService output)
        {
            Assert.IsNotNull(output);
            Output = output;

            Assert.IsNotNull(input);
            Input = input;
            Input.InputReceived += InputReceivedHandler;

            Output.WriteLine(string.IsNullOrWhiteSpace(WelcomeMessage) ? "Welcome to Zork!" : WelcomeMessage);
            //IsRunning = true;
            mIsRunning = true; //IsRunning
        }

        private void InputReceivedHandler(object sender, string commandString)
        {
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
                playerMoves++;
            }

            else
            {
                Output.WriteLine("Unknown command.");
            }
        }

        private static void Move(Game game, Directions direction)
        {
            if (game.Player.Move(direction) == false)
            {
                game.Output.WriteLine("The way is shut!");
            }
        }

        public static void Look(Game game) => game.Output.WriteLine(game.Player.Location.Description);
        
        public void Save(string filename)
        {
            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };

            //using (StreamWriter streamWriter = new StreamWriter(filename))
        //    using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
        //    {
        //        serializer.Serialize(jsonWriter, this);
        //    }
        }

        private static void Restart(Game game)
        {
            game.mIsRunning = false;
            game.mIsRestarting = true;
            Console.Clear();
        }

        private static void Quit(Game game)
        {
            game.IsRunning = false;
            game.GameStopped?.Invoke(game, EventArgs.Empty);
        }

        private void DisplayWelcomeMessage() => Output.WriteLine(WelcomeMessage);

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context) => Player = new Player(World, StartingLocation);

        private bool mIsRunning;
        private bool mIsRestarting;
    }
}
