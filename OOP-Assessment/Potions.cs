using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{

    //inherits from items, represents healing items the player can use in the game
    public class Potions : Items
    {
        //amount of health points restored to the player when item is used
        public int HealAmount {  get; private set; }

        //constructor to create a potion with a name and healing amount
        public Potions(string name, int healAmount)
        {
            Name = name; //sets potions name
            HealAmount = healAmount; //sets how much health is restored to the player when they use the potion
        }

        //overrides the Use method to apply healing effects to the player
        public override void Use(Player player)
        {
            Console.WriteLine($"{player.Name} uses a {Name}, it restores {HealAmount} HP.");
            player.Heal(HealAmount); //calls the players healing method to increase player health
        }
    }
}
