using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    public class Player : Creature 
    {
        public Inventory inventory {  get; private set; }

        public Player(string name) : base(name, 100, 10)
        {
            inventory = new Inventory();
        }

        public override void Attack(Creature target)
        {
            Console.WriteLine($"{Name} attacked {target.Name} with {AttackingPower} power.");
            target.TakeDamage(AttackingPower);
        }

        public void UseItem(string itemName)
        {
            var item = inventory.GetItems(itemName);
            if (item != null)
            {
                item.Use(this);
            }
            else
            {
                Console.WriteLine("Item was not found in Player inventory.");
            }
        }
    }
}
