using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    public class Weapons:Items
    {
        public int Damage {  get; private set; }

        public Weapons(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }

        public override void Use(Player player)
        {
            Console.WriteLine($"{player.Name} equipped {Name}, Player attack is now {Damage}.");
            player.AttackingPower += Damage;
        }
    }
}
