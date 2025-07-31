using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    //main entry point for the dungeion explorer game
    internal class DungeonExplorerProgram
    {
        static void Main(string[] args)
        {
            //runs testsw before game starts to ensure no errors occur during play
            Testing.RunTests();

            //creates a new game
            Game game = new Game();

            //starts game loop
            game.Start();
        }
    }
}
