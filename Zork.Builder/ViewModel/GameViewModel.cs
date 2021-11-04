using Zork;
using System.ComponentModel;
using System.Collections.Generic;

namespace Zork.Builder.ViewModel
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }

        public Game Game { get; set; }

        public string RoomNames { get; set; }

        //public HashSet<Room> AllRooms { get; }
    }
}
