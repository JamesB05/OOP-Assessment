using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    public abstract class Monsters : Creature
    {
        public Monsters(string name, int health, int attackingpower) : base(name, health, attackingpower) { }

    }
}
