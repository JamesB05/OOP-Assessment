using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    public class Rooms
    {
        public string Name { get; }
        public string Description { get; }
        public List<Items> Items { get; }
        public List<Monsters> Monsters { get; }
        public Dictionary<string, Rooms> Exits { get; }

        public Rooms(string name, string description)
        {
            Name = name;
            Description = description;
            Items = new List<Items>();
            Monsters = new List<Monsters>();
            Exits = new Dictionary<string, Rooms>();
        }

        public void ConnectingRooms(string direction, Rooms room)
        {
            Exits[direction] = room;
        }

        public Rooms GetExit(string direction)
        {
            return Exits.ContainsKey(direction) ? Exits[direction] : null;
        }

        public void Describe()
        {
            Console.WriteLine($"\nYou are in {Name}.\n{Description}");

            if (Items.Count > 0)
            {
                Console.WriteLine(""
            }
        }
    }
}
