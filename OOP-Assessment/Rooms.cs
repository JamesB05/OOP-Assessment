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
                Console.WriteLine("You scout the room and see:");
                foreach (var items in Items)
                    Console.WriteLine($" * {items.Name}");
            }

            if (Monsters.Count > 0)
            {
                Console.WriteLine("You feel danger in the air, you spot a:");
                foreach (var monster in Monsters)
                    Console.WriteLine($" * {monster.Name}");
            }

            Console.WriteLine("You look for a path forward, choose your exits:");
            foreach (var exits in Exits)
                Console.WriteLine($" *{exits.Key}");
        }

        public void AddExit(string direction, Rooms rooms)
        {
            Exits[direction.ToLower()] = rooms;
        }
    }
}
