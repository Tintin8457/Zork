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

        Stream fileStream;

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

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get selected file and store it
                string chosenFile = openFileDialog.FileName;
                gameFileObject = JObject.Parse(File.ReadAllText(@chosenFile));
                currentGame = new GameInstance();

                //Assign values to stored references
                currentGame.StartingLocation = gameFileObject["World"]["StartingLocation"].ToString();
                currentGame.WelcomeMessage = gameFileObject["World"]["WelcomeMessage"].ToString();

                currentGame.Rooms = new List<Room>();

                IList<JToken> rooms = gameFileObject["World"]["Rooms"].Children().ToList();
                foreach (JToken room in rooms)
                {
                    Room newRoom = new Room()
                    {
                        Name = room["Name"].ToString(),
                        Description = room["Description"].ToString(),
                        Neighbors = new Neighbors()
                        {
                            North = room["Neighbors"]["North"]?.ToString(),
                            South = room["Neighbors"]["South"]?.ToString(),
                            West = room["Neighbors"]["West"]?.ToString(),
                            East = room["Neighbors"]["East"]?.ToString(),
                        },
                    };

                    currentGame.Rooms.Add(newRoom);
                    //JsonConvert.DeserializeObject<Game>(File.ReadAllText(newRoom.Name));
                    newRoom = null;
                }

                int showRoom = 3;

                MessageBox.Show(currentGame.StartingLocation);
                MessageBox.Show(currentGame.WelcomeMessage);
                MessageBox.Show($"Room: {currentGame.Rooms[showRoom].Name}\n" +
                    $"North Neighbor: {currentGame.Rooms[showRoom].Neighbors.North}\n" +
                    $"South Neighbor: {currentGame.Rooms[showRoom].Neighbors.South}\n" +
                    $"West Neighbor: {currentGame.Rooms[showRoom].Neighbors.West}\n" +
                    $"East Neighbor: {currentGame.Rooms[showRoom].Neighbors.East}");
            }
        }

        private void Save_File(object sender, EventArgs e)
        {
            //
            MessageBox.Show("Save Game File");
        }

        private void Save_As_File(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json files|*.json|All files|*.*";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((fileStream = saveFileDialog.OpenFile()) != null)
                {
                    string fileName = saveFileDialog.FileName;
                    //FileStream fileReader = (FileStream)saveFileDialog.OpenFile();
                    //fileReader.Close();

                    WriteGameFile(fileName);
                    fileStream.Close();
                }
            }
        }

        private void WriteGameFile(string gameFileName)
        {
            try
            {
                using (FileStream fileWriter = File.Open(gameFileName + ".json", FileMode.CreateNew))
                using (StreamWriter writeToGameFile = new StreamWriter(fileWriter))
                using (JsonWriter writetoGameContent = new JsonTextWriter(writeToGameFile))
                {
                    writetoGameContent.Formatting = Formatting.Indented;
                    JsonSerializer serializer = new JsonSerializer();
                    //serializer.Serialize(writetoGameContent); -----------this bit will not work because it needs a certain second argument--------------
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show("Error: Unable to save file.");
            }
        }

        private GameViewModel mGameModel;
    }
}