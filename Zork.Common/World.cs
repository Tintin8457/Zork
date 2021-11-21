using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Zork
{
    public class World
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public List<Room> Rooms { get; set; }

        [JsonIgnore]
        public IReadOnlyDictionary<string, Room> RoomNames => mRoomNames;

        public Player SpawnPlayer() => new Player(this, StartingLocation);

        public Player Player { get; set; }

        public World()
        {
            Rooms = new List<Room>();
            mRoomNames = new Dictionary<string, Room>();
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            mRoomNames = Rooms.ToDictionary(room => room.Name, room => room);

            foreach (Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }
        }

        [JsonProperty]
        private string StartingLocation { get; set; }

        private Dictionary<string, Room> mRoomNames;
    }
}