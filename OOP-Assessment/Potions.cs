using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    public class Potions : Items
    {
        public int HealAmount {  get; private set; }

        public Potions(string name, int healAmount)
        {
            Name = name;
            HealAmount = healAmount;
        }

        public override void Use(Player player)
        {
            Console.WriteLine($"{player.Name} uses a {Name}, it restores {HealAmount} HP.");
            player.Heal(HealAmount);
        }
    }
}
