using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    //simple testing class to verify game mechanics work as intended
    public class Testing
    {
        //static method that runs various tests using debug assert
        //if an assertation fails, the test will throw an error
        public static void RunTests()
        {
            //tests weapon creation and damage value
            Weapons sword = new Weapons("Test Sword", 10);
            Debug.Assert(sword.Damage == 10); //verifies sword damage

            //tests potion creation and healing value
            Potions potion = new Potions("Test Potion", 25);
            Debug.Assert(potion.HealAmount == 25);// verifies healing amount

            //tests combat: test player attacks test orc and orc health decreases
            Player p = new Player("Tester");
            Orc o = new Orc();
            p.Attack(o);
            Debug.Assert(o.Health < 30); //checks orc health is below 30 after attack

            //if all tests are passed, confirmation is printed to player console
            Console.WriteLine("All tests passed.");
        }
    }
}
