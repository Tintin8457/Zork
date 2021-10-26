using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork
{
    public class World
    {
        public HashSet<Room> Rooms { get; set; }

        [JsonIgnore]
        public ReadOnlyDictionary<string, Room> RoomNames => new ReadOnlyDictionary<string, Room> (mRoomNames);

        public Player SpawnPlayer() => new Player(this, StartingLocation);

        public Player Player { get; set; }

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