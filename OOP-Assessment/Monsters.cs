using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    public abstract class Monsters:Creature
    {
        public Monsters(string name, int health, int attackingpower) : base(name, health, attackingpower) { }

    }

    public class Orc : Monsters
    {
        public Orc() : base("Orc", 30, 5) { }

        public override void Attack(Creature target)
        {
            Console.WriteLine("The Orc lunges his Warhammer towards you!");
            target.TakeDamage(AttackingPower);
        }
    }

    public class Beholder : Monsters
    {
        public Beholder() : base("Beholder", 200, 30) { }
        public override void Attack(Creature target)
        {
            Console.WriteLine("The Beholder opens its gaping jaw and bites you!");
            target.TakeDamage(AttackingPower);
        }
    }
}
