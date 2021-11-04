using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zork;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using Zork.Builder.ViewModel;

namespace Zork.Builder
{
    public partial class Form1 : Form
    {
        public GameInstance currentGame;
        public JObject gameFileObject;
        private GameViewModel ZorkGame 
        { 
            get => mGameModel;

            set
            {
                if (mGameModel != value)
                {
                    mGameModel = value;
                    roomsBindingSource.DataSource = mGameModel;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            ZorkGame = new GameViewModel();
        }

        private void Game_Click(object sender, EventArgs e)
        {
            //Triggers whenever you click the screen while in the game tab
            //MessageBox.Show("Clicked Game Tab");
        }

        private void New_File(object sender, EventArgs e)
        {
            //
            MessageBox.Show("New Game File");
        }

        private void Open_File(object sender, EventArgs e)
        {
            //
            //MessageBox.Show("Open Game File");
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Game Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "json",
                Filter = "Json files (*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            //OpenFileDialog openFileDialog = new GetFileDialog { };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get selected file and store it
                string chosenFile = openFileDialog.FileName;
                gameFileObject = JObject.Parse(File.ReadAllText(@chosenFile));
                currentGame = new GameInstance();

                //Assign values to stored references
                currentGame.StartingLocation = gameFileObject["World"]["StartingLocation"].ToString();
                currentGame.WelcomeMessage = gameFileObject["World"]["WelcomeMessage"].ToString();

                //-------------Temporary placement for deserializing json file-------------------
                ZorkGame.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                ZorkGame.Filename = openFileDialog.FileName;

                IList<JToken> rooms = gameFileObject["World"]["Rooms"].Children().ToList();
                foreach (JToken room in rooms)
                {
                    //Room newRoom = new Room();
                    //newRoom.Name = room["Name"].ToString();
                    //currentGame.Rooms.Add(room);

                    string mName = room["Name"].ToString();
                    string mDescription = room["Description"].ToString();
                    Dictionary<string, string> mNeighbors = new Dictionary<string, string>();

                    foreach (JToken neighbor in room["Neighbors"].Children().ToList())
                    {
                        mNeighbors.Add(neighbor.ToString(), neighbor.Value<string>());
                    }

                    currentGame.Rooms.Add((mName, mDescription, mNeighbors));
                }

                MessageBox.Show(currentGame.StartingLocation);
                MessageBox.Show(currentGame.WelcomeMessage);
                MessageBox.Show(currentGame.Rooms[0].Item1);
            }
        }

        private void Save_File(object sender, EventArgs e)
        {
            //
            MessageBox.Show("Save Game File");
        }

        private void Save_As_File(object sender, EventArgs e)
        {
            //
            //MessageBox.Show("Save Game File As...");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json files|*.json|All files|*.*";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                FileStream fileReader = (FileStream)saveFileDialog.OpenFile();
                fileReader.Close();
            }
        }

        private GameViewModel mGameModel;
    }
}
