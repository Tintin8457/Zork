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
        public Root StoredRoot = null;
        public string CurrentFile = "";

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
            //Create a new world in the form, but don't save or write it

            StoredRoot = null;
            CurrentFile = "";

            StoredRoot = new Root()
            {
                World = new World()
                {
                    StartingLocation = "",
                    WelcomeMessage = "Welcome to Zork!",
                    Rooms = new List<Room>(),
                },
            };

            StoredRoot.World.Rooms.Add(new Room()
            {
                Name = "Default Room",
                Description = "Default Room Description",
                Neighbors = new Neighbors()
                {
                    North = null,
                    South = null,
                    West = null,
                    East = null,
                },
            });

            MessageBox.Show($"Stored Root: {StoredRoot.World.WelcomeMessage}\n" +
                $"File Name: {CurrentFile};");
        }

        private void Open_File(object sender, EventArgs e)
        {
            //Open file dialog with settings
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
                CurrentFile = openFileDialog.FileName;

                MessageBox.Show(CurrentFile);

                //Get the whole world from the file
                StoredRoot = JsonConvert.DeserializeObject<Root>(File.ReadAllText(@CurrentFile));

                MessageBox.Show("File Successfully Loaded!");
            }
        }

        private void Save_File(object sender, EventArgs e)
        {
            if (CurrentFile == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Json files|*.json|All files|*.*",
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CurrentFile = saveFileDialog.FileName;

                    MessageBox.Show(CurrentFile);
                }
            }

            //convert to json
            string json = JsonConvert.SerializeObject(StoredRoot, Formatting.Indented);

            //write json to the current file
            File.WriteAllText(CurrentFile, json);
        }

        private void Save_As_File(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Json files|*.json|All files|*.*",
            };

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFile = saveFileDialog.FileName;

                MessageBox.Show(CurrentFile);

                //convert to json
                string json = JsonConvert.SerializeObject(StoredRoot, Formatting.Indented);

                //write json to the current file
                File.WriteAllText(CurrentFile, json);
            }
        }

        //private void Save_As_File(object sender, EventArgs e)
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.Filter = "Json files|*.json|All files|*.*";
        //    saveFileDialog.ShowDialog();

        //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        if ((fileStream = saveFileDialog.OpenFile()) != null)
        //        {
        //            string fileName = saveFileDialog.FileName;
        //            //FileStream fileReader = (FileStream)saveFileDialog.OpenFile();
        //            //fileReader.Close();

        //            WriteGameFile(fileName);
        //            fileStream.Close();
        //        }
        //    }
        //}

        //private void WriteGameFile(string gameFileName)
        //{
        //    try
        //    {
        //        using (FileStream fileWriter = File.Open(gameFileName + ".json", FileMode.CreateNew))
        //        using (StreamWriter writeToGameFile = new StreamWriter(fileWriter))
        //        using (JsonWriter writetoGameContent = new JsonTextWriter(writeToGameFile))
        //        {
        //            writetoGameContent.Formatting = Formatting.Indented;
        //            JsonSerializer serializer = new JsonSerializer();
        //            //serializer.Serialize(writetoGameContent); -----------this bit will not work because it needs a certain second argument--------------
        //        }
        //    }

        //    catch (Exception exception)
        //    {
        //        MessageBox.Show("Error: Unable to save file.");
        //    }
        //}

        private GameViewModel mGameModel;
    }
}