using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    public class Inventory
    {
        private List<Items> Items = new List<Items>();

        public void AddItems(Items items)
        {
            Items.Add(items);
            Console.WriteLine($"{items.Name} was added to your inventory.");
        }

        public Items GetItems(string name)
        {
            return Items.FirstOrDefault(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

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

        public List<Items> FilterWeapons()
        {
            return Items
                .Where(i => i is Weapons)
                .Cast<Items>()
                .ToList();
        }
    }
}
