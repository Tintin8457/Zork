using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zork
{
    public class Player
    {
        public World World { get; }

        [JsonIgnore]
        public Room Location { get; private set; }

        [JsonIgnore]
        public string LocationName
        {
            get
            {
                return Location?.Name;
            }

            set
            {
                Location = World?.RoomNames.GetValueOrDefault(value);
            }
        }

        public Player(World mWorld, string startLocation)
        {
            World = mWorld;
            LocationName = startLocation;
        }

        public bool Move(Directions direction)
        {
            bool validMove = Location.Neighbors.TryGetValue(direction, out Room destination);

            if (validMove)
            {
                Location = destination;
            }

            return validMove;
        }
    }
}