using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zork
{
    public class Player 
    {
        public event EventHandler<Room> LocationChanged;
        public event EventHandler<int> ScoreChanged;
        public event EventHandler<EventArgs> PlayerChanged;

        public World World { get; }

        [JsonIgnore]
        public Room Location 
        {
            get
            {
                return _location;
            }

            private set
            {
                if(LocationChanged != null)
                {
                    _location = value;
                    LocationChanged.Invoke(this, _location);
                }
            }
        }

        public Player(World mWorld, string startLocation)
        {
            Assert.IsTrue(mWorld != null);
            Assert.IsTrue(mWorld.RoomNames.ContainsKey(startLocation));

            World = mWorld;
            Location = mWorld.RoomNames[startLocation];
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