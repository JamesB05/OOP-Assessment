using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{

    // keeps track of player progress in the game, such as rooms entered and how many monsters the player has defeated
    public class Statistics
    {
        // counts how many rooms the player has visited, starts at 0
        public int RoomsVisited { get; set; } = 0;

        //tracks how many monsters the player has defeated, starts at 0
        public int MonstersDefeated { get; set; } = 0;

        //prints out the current game stats to the player
        public void ShowStats()
        {
            Console.WriteLine($"\n*** Game Stats ***");
            Console.WriteLine($"Rooms visited: {RoomsVisited}");//outputs the number of rooms players have explored
            Console.WriteLine($"Monsters defeated: {MonstersDefeated}");//outputs how many monsters the player has defeated
        }
    }
}
