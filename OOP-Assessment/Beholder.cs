using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    public class Beholder : Monsters
    {
        public Beholder() : base("Beholder", 200, 30) { }
        public virtual void Attack(Creature target)
        {
            Console.WriteLine("The Beholder opens its gaping jaw and bites you!");
            target.TakeDamage(AttackingPower);
        }
    }
}
