using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    internal class DungeonExplorerProgram
    {
        static void Main(string[] args)
        {
            Testing.RunTests();

            Game game = new Game();
            game.Start();
        }
    }
}
