using System;
using System.IO;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Zork
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public World World { get; set; }

        public IOutputService Output { get; set; }
        public IInputService Input { get; set; }

        public string WelcomeMessage { get; set; }
        public string ExitMessage { get; set; }

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

        public void Start(IInputService input, IOutputService output)
        {
            Assert.IsNotNull(output);
            Output = output;

            Assert.IsNotNull(input);
            Input = input;

            Input.InputReceived += InputReceivedHandler;

            Output.WriteLine(string.IsNullOrWhiteSpace(WelcomeMessage) ? "Welcome to Zork!" : WelcomeMessage);
            IsRunning = true;
            

            //IsRunning = true;
            //Room previousRoom = null;
            //Output.WriteLine(Player.Location);

            //if (previousRoom != Player.Location)
            //{
            //    Look(this);
            //    previousRoom = Player.Location;
            //}

            //Output.WriteLine("\n> ");

            //Commands commandFound = null;

            //while (IsRunning)
            //{
            //    Output.WriteLine(Player.Location);

            //    if (previousRoom != Player.Location)
            //    {
            //        Output.WriteLine(Player.Location.Description);
            //        Look(this);
            //        previousRoom = Player.Location;
            //    }

            //    Output.WriteLine("\n> ");
            //    //Commands command = ToCommand(Console.ReadLine().Trim());

            //    switch (command)
            //    {
            //        case Commands.QUIT:
            //            IsRunning = false;
            //            break;

            //        case Commands.LOOK:
            //            Output.WriteLine(Player.Location.Description);
            //            playerMoves++;
            //            break;

            //        case Commands.SCORE:
            //            Output.WriteLine("Your score would be " + playerScore + " in " + playerMoves + " moves.");
            //            playerMoves++;
            //            break;

            //        case Commands.REWARD:
            //            playerScore++;
            //            break;

            //        case Commands.NORTH:
            //        case Commands.SOUTH:
            //        case Commands.EAST:
            //        case Commands.WEST:
            //            Directions direction = (Directions)command;
            //            playerMoves++;

            //            if (Player.Move(direction) == false)
            //            {
            //                Output.WriteLine("The way is shut!");
            //                playerMoves++;
            //            }

            //            break;

            //        default:
            //            Output.WriteLine("Unknown Command.");
            //            break;
            //    }
            //}
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
                //game.playerMoves++;
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

        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result: Commands.UNKNOWN;
    }
}
