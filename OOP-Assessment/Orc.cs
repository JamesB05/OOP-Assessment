using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    //specified stats for the orc monster variant in the game
    public class Orc : Monsters
    {
        //creates an orc with default name, health and attack power
        public Orc() : base("Orc", 30, 5) { }

        //Orc can attack the player when the room is entered, damage is calculated by the attacking power of the orc
        public virtual void Attack(Creature target)
        {
            Console.WriteLine("The Orc lunges his Warhammer towards you!");
            target.TakeDamage(AttackingPower); // target loses health equal to Orc's attacking power
        }
    }
}