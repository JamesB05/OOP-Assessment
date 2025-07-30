using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    public class Orc : Monsters
    {
        public Orc() : base("Orc", 30, 5) { }

        public override void Attack(Creature target)
        {
            Console.WriteLine("The Orc lunges his Warhammer towards you!");
            target.TakeDamage(AttackingPower);
        }
    }
}