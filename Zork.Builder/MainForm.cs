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
    public partial class MainForm : Form
    {
        public Root StoredRoot = null;
        public string CurrentFile = "";

        private GameViewModel ZorkGame 
        { 
            get => mGameModel;

            set
            {
                if (mGameModel != value)
                {
                    mGameModel = value;
                    defaultBindingSource.DataSource = mGameModel;
                }
            }
        }

        public MainForm()
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
            ResetApp();

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

            //editorBindingSource.Add(StoredRoot.World.Rooms);
            //Link to binding source in new file
            //roomsBindingSource.DataSource = StoredRoot.World.Rooms;
            

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
                ResetApp();

                //Get selected file and store it
                CurrentFile = openFileDialog.FileName;

                MessageBox.Show(CurrentFile);

                //Get the whole world from the file
                StoredRoot = JsonConvert.DeserializeObject<Root>(File.ReadAllText(@CurrentFile));

                //Link to binding source in existing file
                roomsBindingSource.DataSource = CurrentFile;

                MessageBox.Show("File Successfully Loaded!");
            }
            
            foreach(Room room in GetRoomsList())
            {
                RoomsListBox.Items.Add(room);
                StartingLocationDropBox.Items.Add(room);
            }
            RoomsListBox.ValueMember = "Room";
            RoomsListBox.DisplayMember = "Name";

            StartingLocationDropBox.Text = StoredRoot.World.StartingLocation;

            StartingLocationDropBox.ValueMember = "Room";
            StartingLocationDropBox.DisplayMember = "Name";
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

        private GameViewModel mGameModel;

        private void RoomAddButton_Click(object sender, EventArgs e)
        {

        }

        private void RoomRemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeMessageTextBox_Changed(object sender, EventArgs e)
        {
            StoredRoot.World.WelcomeMessage = WelcomeMessageTextBox.Text;
        }

        private void RoomsListBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private List<Room> GetRoomsList()
        {
            return StoredRoot.World.Rooms;
        }

        private void StartingLocationDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoredRoot.World.StartingLocation = StartingLocationDropBox.Text;
        }

        private void RoomNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetApp()
        {
            RoomsListBox.Items.Clear();
            StartingLocationDropBox.Items.Clear();
        }
    }
}