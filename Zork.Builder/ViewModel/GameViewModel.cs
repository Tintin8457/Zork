using Zork;
using System.ComponentModel;
using System.Collections.Generic;

namespace Zork.Builder.ViewModel
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string FileName { get; set; }
        public string StartingLocation { get; set; }
        public string WelcomeMessage { get; set; }
        public BindingList<Room> Rooms {get; set;}
        public Game Game { get; set; }
        public Player Player { get; set; }
        public World World { get; set; }

        //public string RoomNames { get; set; }
    }
}
