using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{

    //represents a dungeon room, including its contents and exits
    public class Rooms
    {
        //the rooms name
        public string Name { get; }
        
        //a description of the room to add atmosphere
        public string Description { get; }

        //a list holding all the items in the room
        public List<Items> Items { get; }

        //a list holding all monsters present in the room
        public List<Monsters> Monsters { get; }

        //dictionary that maps the room exits to neighbouring rooms
        public Dictionary<string, Rooms> Exits { get; }

        //initialises room with a name, description and empty lists and dictionarys for items, monsters and exits
        public Rooms(string name, string description)
        {
            Name = name;
            Description = description;
            Items = new List<Items>();
            Monsters = new List<Monsters>();
            Exits = new Dictionary<string, Rooms>();
        }

        //adds a connection between rooms in specified direction
        public void ConnectingRooms(string direction, Rooms room)
        {
            Exits[direction] = room;
        }

        // return the rooms in any given direction, if there isnt none it returns null
        public Rooms GetExit(string direction)
        {
            return Exits.ContainsKey(direction) ? Exits[direction] : null;
        }

        //Describes the rooms name, description, exits and creatures or items inside
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

        // Adds/updates an exit in the given direction
        public void AddExit(string direction, Rooms rooms)
        {
            Exits[direction.ToLower()] = rooms; //converts direction to lowercase
        }
    }
}
