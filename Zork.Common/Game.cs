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

        public void Run(IOutputService output, IInputService input)
        {
            Assert.IsNotNull(output);
            Output = output;

            Assert.IsNotNull(input);
            Input = input;
            Input.InputReceived += InputReceivedHandler;

            IsRunning = true;
            Room previousRoom = null;

            //while (IsRunning)
            //{
            //    Output.WriteLine(Player.Location);

            //    if (previousRoom != Player.Location)
            //    {
            //        Output.WriteLine(Player.Location.Description);
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

            //if (foundCommand != null)
            //{
            //    foundCommand.Act
            //}
        }

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
