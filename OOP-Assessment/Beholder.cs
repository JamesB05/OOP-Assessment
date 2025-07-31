using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    //a powerful enemy monster that deals high damage and has high HP
    public class Beholder : Monsters
    {
        //initialises monsters name, health and attack power
        public Beholder() : base("Beholder", 200, 30) { }

        //attack method, deals damage to the player equal to Beholders attacking power
        public virtual void Attack(Creature target)
        {
            Console.WriteLine("The Beholder opens its gaping jaw and bites you!");
            target.TakeDamage(AttackingPower);
        }
    }
}
