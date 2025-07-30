using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    public class Testing
    {
        public static void RunTests()
        {
            Weapons sword = new Weapons("Test Sword", 10);
            Debug.Assert(sword.Damage == 10);


            Potions potion = new Potions("Test Potion", 25);
            Debug.Assert(potion.HealAmount == 25);


            Player p = new Player("Tester");
            Orc o = new Orc();
            p.Attack(o);
            Debug.Assert(o.Health < 30);

            Console.WriteLine("All tests passed.");
        }
    }
}
