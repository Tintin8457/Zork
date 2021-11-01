using System.Collections.Generic;

namespace Zork.Builder
{
    public class GameInstance
    {
        public string StartingLocation { get; set; }
        public string WelcomeMessage { get; set; }
        public List<(string, string, Dictionary<string, string>)> Rooms { get; set; }
    }
}
