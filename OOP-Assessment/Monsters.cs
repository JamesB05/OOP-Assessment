using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    //abstract base class for all monsters in the game
    //inherits from Creature class, monsters share common properties (attack power, health)
    public abstract class Monsters : Creature
    {
        //initialises monster name, health and attacking power
        //calls the base class constructor to set values
        public Monsters(string name, int health, int attackingpower) : base(name, health, attackingpower) { }

    }
}
