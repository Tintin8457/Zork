using System.Collections.Generic;

namespace Zork.Builder
{
    public class GameInstance
    {
        public string StartingLocation { get; set; }
        public string WelcomeMessage { get; set; }
        public List<Room> Rooms { get; set; }
    }

    public class Neighbors
    {
        public string North { get; set; }
        public string South { get; set; }
        public string West { get; set; }
        public string East { get; set; }
    }

    public class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Neighbors Neighbors { get; set; }
    }
}
