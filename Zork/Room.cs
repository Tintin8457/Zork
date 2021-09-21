namespace Zork
{
    public class Room
    {
        public string Name { get; }
        public string Description { get; set; }

        public override string ToString() => Name;

        public Room (string rName, string rInfo = "")
        {
            Name = rName;
            Description = rInfo;
        }
    }
}
