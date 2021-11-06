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

            RoomsListBox.Items.Clear();

            foreach (Room room in GetRoomsList())
            {
                RoomsListBox.Items.Add(room);
            }
            RoomsListBox.DisplayMember = "Name";
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

                //MessageBox.Show(CurrentFile);

                //Get the whole world from the file
                StoredRoot = JsonConvert.DeserializeObject<Root>(File.ReadAllText(@CurrentFile));

                MessageBox.Show("File Successfully Loaded!");
            }

            RoomsListBox.Items.Clear();

            foreach(Room room in GetRoomsList())
            {
                RoomsListBox.Items.Add(room);
                StartingLocationDropBox.Items.Add(room);
            }
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

        



        private void WelcomeMessageTextBox_Changed(object sender, EventArgs e)
        {
            StoredRoot.World.WelcomeMessage = WelcomeMessageTextBox.Text;
        }

        private void RoomsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Name and Description
                RoomNameTextBox.Text = (RoomsListBox.SelectedItem as Room).Name;
                RoomDescriptionTextBox.Text = (RoomsListBox.SelectedItem as Room).Description;

                //North Neighbor
                NeighborNorthDropBox.Items.Clear();
                NeighborNorthDropBox.Text = (RoomsListBox.SelectedItem as Room).Neighbors.North;
                foreach (Room room in GetRoomsList())
                {
                    if(room.Name != (RoomsListBox.SelectedItem as Room).Name)
                        NeighborNorthDropBox.Items.Add(room);
                }
                NeighborNorthDropBox.DisplayMember = "Name";

                //South Neighbor
                NeighborSouthDropBox.Items.Clear();
                NeighborSouthDropBox.Text = (RoomsListBox.SelectedItem as Room).Neighbors.South;
                foreach (Room room in GetRoomsList())
                {
                    if (room.Name != (RoomsListBox.SelectedItem as Room).Name)
                        NeighborSouthDropBox.Items.Add(room);
                }
                NeighborSouthDropBox.DisplayMember = "Name";

                //West Neighbor
                NeighborWestDropBox.Items.Clear();
                NeighborWestDropBox.Text = (RoomsListBox.SelectedItem as Room).Neighbors.West;
                foreach (Room room in GetRoomsList())
                {
                    if (room.Name != (RoomsListBox.SelectedItem as Room).Name)
                        NeighborWestDropBox.Items.Add(room);
                }
                NeighborWestDropBox.DisplayMember = "Name";

                //East Neighbor
                NeighborEastDropBox.Items.Clear();
                NeighborEastDropBox.Text = (RoomsListBox.SelectedItem as Room).Neighbors.East;
                foreach (Room room in GetRoomsList())
                {
                    if (room.Name != (RoomsListBox.SelectedItem as Room).Name)
                        NeighborEastDropBox.Items.Add(room);
                }
                NeighborEastDropBox.DisplayMember = "Name";
            }
            catch { }
        }

        private void RoomUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = RoomsListBox.SelectedIndex;

                StoredRoot.World.Rooms[index].Name = RoomNameTextBox.Text;
                StoredRoot.World.Rooms[index].Description = RoomDescriptionTextBox.Text;

                StoredRoot.World.Rooms[index].Neighbors.North = NeighborNorthDropBox.Text;
                StoredRoot.World.Rooms[index].Neighbors.South = NeighborSouthDropBox.Text;
                StoredRoot.World.Rooms[index].Neighbors.West = NeighborWestDropBox.Text;
                StoredRoot.World.Rooms[index].Neighbors.East = NeighborEastDropBox.Text;

                RoomsListBox.Items.RemoveAt(index);
                RoomsListBox.Items.Insert(index, StoredRoot.World.Rooms[index]);
            }
            catch { }
        }

        private void RoomAddButton_Click(object sender, EventArgs e)
        {
            StoredRoot.World.Rooms.Add(new Room()
            {
                Name = "New Room",
                Description = "New Room Description",
                Neighbors = new Neighbors()
                {
                    North = null,
                    South = null,
                    West = null,
                    East = null,
                },
            });

            RoomsListBox.Items.Add(StoredRoot.World.Rooms[StoredRoot.World.Rooms.Count - 1]);
        }

        private void RoomRemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = RoomsListBox.SelectedIndex;

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this room?", "Remove Room", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Find and remove all links to current room
                    PurgeDeadNeighborsByName((RoomsListBox.SelectedItem as Room).Name);

                    //Clear Room Text
                    RoomNameTextBox.Text = null;
                    RoomDescriptionTextBox.Text = null;

                    //Clear North Neighbor DropBox
                    NeighborNorthDropBox.Text = null;
                    NeighborNorthDropBox.Items.Clear();

                    //Clear South Neighbor DropBox
                    NeighborSouthDropBox.Text = null;
                    NeighborSouthDropBox.Items.Clear();

                    //Clear West Neighbor DropBox
                    NeighborWestDropBox.Text = null;
                    NeighborWestDropBox.Items.Clear();

                    //Clear East Neighbor DropBox
                    NeighborEastDropBox.Text = null;
                    NeighborEastDropBox.Items.Clear();

                    //Update Lists
                    StoredRoot.World.Rooms.RemoveAt(index);
                    RoomsListBox.Items.RemoveAt(index);
                    MessageBox.Show("Room Removed!");
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Room Unchanged!");
                }
            }
            catch { }
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
        private bool RoomExistsByName(string name)
        {
            bool exists = false;
            foreach(Room room in GetRoomsList())
            {
                if(room.Name == name)
                {
                    exists = true;
                    return exists;
                }
            }

            return exists;
        }

        private void PurgeDeadNeighborsByName(string name)
        {
            if (StartingLocationDropBox.Text == name)
            {
                StoredRoot.World.StartingLocation = null;
                StartingLocationDropBox.Text = null;
            }

            foreach (Room room in GetRoomsList())
            {
                if (room.Neighbors.North == name)
                    room.Neighbors.North = null;

                if (room.Neighbors.South == name)
                    room.Neighbors.South = null;

                if (room.Neighbors.West == name)
                    room.Neighbors.West = null;

                if (room.Neighbors.East == name)
                    room.Neighbors.East = null;
            }
        }
    }
}