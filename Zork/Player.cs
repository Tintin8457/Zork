using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zork
{
    public class Player
    {
        public World World { get; }

        [JsonIgnore]
        public Room Location { get; private set; }

        /*public Room CurrentRoom
        {
            get
            {
                return Rooms[Locate.locationRow, Locate.locationColumn];
            }
        }
        private (int locationRow, int locationColumn) Locate;*/

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

           /* switch (command)
            {
                case Commands.NORTH when Locate.locationRow < Rooms.GetLength(1) - 1:
                    Locate.locationRow++;
                    validMove = true;
                    break;

                case Commands.SOUTH when Locate.locationRow > 0:
                    Locate.locationRow--;
                    validMove = true;
                    break;

                case Commands.WEST when Locate.locationColumn > 0:
                    Locate.locationColumn--;
                    didMove = true;
                    validMove;

                case Commands.EAST when Locate.locationColumn < Rooms.GetLength(1) - 1:
                    Locate.locationColumn++;
                    validMove = true;
                    break;
            }*/

            return validMove;
        }
    }
}