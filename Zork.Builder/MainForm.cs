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

        private void New_File(object sender, EventArgs e)
        {
            //Create a new world in the form, but don't save or write it
            StoredRoot = null;
            CurrentFile = "";

            StoredRoot = new Root()
            {
                World = new World()
                {
                    StartingLocation = null,
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

            ResetWorldLists();

            StartingLocationDropBox.Text = StoredRoot.World.StartingLocation = StoredRoot.World.Rooms[0].Name;

            WelcomeMessageTextBox.Text = StoredRoot.World.WelcomeMessage;

            //Clear the Form
            ClearRoomForm();
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

                //Get the whole world from the file
                StoredRoot = JsonConvert.DeserializeObject<Root>(File.ReadAllText(@CurrentFile));
            }

            ResetWorldLists();

            StartingLocationDropBox.Text = StoredRoot.World.StartingLocation;

            WelcomeMessageTextBox.Text = StoredRoot.World.WelcomeMessage;

            //Clear the Form
            ClearRoomForm();
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
                }
            }

            //convert to json
            string json = JsonConvert.SerializeObject(StoredRoot, Formatting.Indented);

            //write json to the current file
            File.WriteAllText(CurrentFile, json);

            MessageBox.Show(CurrentFile + " is saved");
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

                MessageBox.Show(CurrentFile + " is saved");

                //convert to json
                string json = JsonConvert.SerializeObject(StoredRoot, Formatting.Indented);

                //write json to the current file
                File.WriteAllText(CurrentFile, json);
            }
        }

        private GameViewModel mGameModel;

        private void WelcomeMessageTextBox_Changed(object sender, EventArgs e)
        {
            if (StoredRoot != null)
            {
                StoredRoot.World.WelcomeMessage = WelcomeMessageTextBox.Text;
                MessageBox.Show($"New Message: {StoredRoot.World.WelcomeMessage}");
            }
        }

        private void StartingLocationDropBox_Changed(object sender, EventArgs e)
        {
            StoredRoot.World.StartingLocation = StartingLocationDropBox.Text;
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

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RoomUpdateButton_Click(object sender, EventArgs e)
        {
            if(RoomsListBox.SelectedItem != null)
            {
                try
                {
                    int index = RoomsListBox.SelectedIndex;

                    string oldName = StoredRoot.World.Rooms[index].Name;

                    StoredRoot.World.Rooms[index].Name = RoomNameTextBox.Text;
                    StoredRoot.World.Rooms[index].Description = RoomDescriptionTextBox.Text;

                    StoredRoot.World.Rooms[index].Neighbors.North = NeighborNorthDropBox.Text;
                    StoredRoot.World.Rooms[index].Neighbors.South = NeighborSouthDropBox.Text;
                    StoredRoot.World.Rooms[index].Neighbors.West = NeighborWestDropBox.Text;
                    StoredRoot.World.Rooms[index].Neighbors.East = NeighborEastDropBox.Text;

                    RoomsListBox.Items.RemoveAt(index);
                    RoomsListBox.Items.Insert(index, StoredRoot.World.Rooms[index]);

                    StartingLocationDropBox.Items.RemoveAt(index);
                    StartingLocationDropBox.Items.Insert(index, StoredRoot.World.Rooms[index]);

                    UpdateNeighborsByName(oldName, StoredRoot.World.Rooms[index].Name);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
            StartingLocationDropBox.Items.Add(StoredRoot.World.Rooms[StoredRoot.World.Rooms.Count - 1]);
        }

        private void RoomRemoveButton_Click(object sender, EventArgs e)
        {
            if (RoomsListBox.SelectedItem != null)
            {
                try
                {
                    int index = RoomsListBox.SelectedIndex;

                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this room?", "Remove Room", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Find and remove all links to current room
                        PurgeNeighborsByName((RoomsListBox.SelectedItem as Room).Name);

                        //Clear the Form
                        ClearRoomForm();

                        //Update Lists
                        StoredRoot.World.Rooms.RemoveAt(index);
                        RoomsListBox.Items.RemoveAt(index);
                        StartingLocationDropBox.Items.RemoveAt(index);
                        MessageBox.Show("Room Removed!");
                    }

                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Room Unchanged!");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private List<Room> GetRoomsList()
        {
            return StoredRoot.World.Rooms;
        }

        private void PurgeNeighborsByName(string name)
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

        private void UpdateNeighborsByName(string oldName, string newName)
        {
            if(oldName != newName)
            {
                if (StartingLocationDropBox.Text == oldName)
                {
                    StoredRoot.World.StartingLocation = newName;
                    StartingLocationDropBox.Text = newName;
                }

                foreach (Room room in GetRoomsList())
                {
                    if (room.Neighbors.North == oldName)
                        room.Neighbors.North = newName;

                    if (room.Neighbors.South == oldName)
                        room.Neighbors.South = newName;

                    if (room.Neighbors.West == oldName)
                        room.Neighbors.West = newName;

                    if (room.Neighbors.East == oldName)
                        room.Neighbors.East = newName;
                }
            }
        }

        private void ResetWorldLists()
        {
            RoomsListBox.Items.Clear();
            StartingLocationDropBox.Items.Clear();

            foreach (Room room in GetRoomsList())
            {
                RoomsListBox.Items.Add(room);
                StartingLocationDropBox.Items.Add(room);
            }

            RoomsListBox.DisplayMember = "Name";
            StartingLocationDropBox.DisplayMember = "Name";
        }

        private void ClearRoomForm()
        {
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
        }
    }
}