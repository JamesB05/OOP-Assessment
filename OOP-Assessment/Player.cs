using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    //player class representing the user character
    //inherits from creature to get health, attack and damage functionality
    public class Player : Creature 
    {
        //players inventory to store items and weapons, read only from outside of class
        public Inventory inventory {  get; private set; }

        //initialises player with a name, default 100 health and attack power of 10
        public Player(string name) : base(name, 100, 10)
        {
            inventory = new Inventory();
        }

        //overrides attack method to perform attack on another creature
        public virtual void Attack(Creature target)
        {
            Console.WriteLine($"{Name} attacked {target.Name} with {AttackingPower} power.");
            target.TakeDamage(AttackingPower);
        }

        //allows user to use an item
        public void UseItem(string itemName)
        {
            var item = inventory.GetItems(itemName); // searches inventory for item
            if (item != null)
            {
                item.Use(this); //uses item on player
            }
            else
            {
                Console.WriteLine("Item was not found in Player inventory.");
            }
        }
    }
}
