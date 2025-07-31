using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    //manages a collection of items the player collects on their journey
    public class Inventory
    {
        //internal list to store items in player inventory
        private List<Items> Items = new List<Items>();

        //adds item to inventory and informs the player
        public void AddItems(Items items)
        {
            Items.Add(items);
            Console.WriteLine($"{items.Name} was added to your inventory.");
        }

        //retrieves item by its name (ignores caps), or null if no item is available
        public Items GetItems(string name)
        {
            return Items.FirstOrDefault(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        //lists all the items in player inventory and returns a message if empty
        public void ListItems()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("You have no items in your inventory.");
                return;
            }

            Console.WriteLine("Inventory contents:");
            foreach (var items in Items)
            {
                Console.WriteLine($"* {items.Name}");
                
            }
        }

        //returns a list of weapons in player inventory
        //Uses LINQ to filter items by type

        public List<Items> FilterWeapons()
        {
            return Items
                .Where(i => i is Weapons) //keeps only weapons
                .Cast<Items>() 
                .ToList(); //converts to list<Items>
        }
    }
}
