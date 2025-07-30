using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    //Weapons class inherits from Items and allows players to use weapon items
    public class Weapons:Items
    {
        //The damage value the weapon will add to players attacking power
        public int Damage {  get; private set; }

        //constructor allowing us to create a weapon with a name and damage value
        public Weapons(string name, int damage)
        {
            Name = name; //sets the name of the weapon
            Damage = damage; //sets the damage the weapon deals
        }

        //overrides the Use method to equip weapon and increase player attack
        public override void Use(Player player)
        {
            Console.WriteLine($"{player.Name} equipped {Name}, Player attack is now {Damage}.");
            player.IncreaseAttackingPower( Damage ); // increases players attack power relative to weapon damage
        }
    }
}
