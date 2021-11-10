using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zork
{
    public class Player 
    {
        public event EventHandler<Room> LocationChanged;

        public World World { get; }

        [JsonIgnore]
        public Room Location { get; private set; }
        
        [JsonIgnore]
        public string LocationName
        {
            get
            {
                return _location?.Name;
            }

            set
            {
                if (_location != value)
                {
                    _location = World?.RoomNames.GetValueOrDefault(value);
                    LocationChanged?.Invoke(this, _location);
                }
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

        private Room _location;
    }
}