using Zork;
using System.ComponentModel;
using System.Collections.Generic;

namespace Zork.Builder.ViewModel
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string StartingLocation { get; set; }
        public string WelcomeMessage { get; set; }

        public Room zorkRoom { get; set; }

        ///DO NOT REMOVE GAME GAME////
        public Game Game { get; set; }

        //public string RoomNames { get; set; }

        //public HashSet<Room> AllRooms { get; }
    }
}
