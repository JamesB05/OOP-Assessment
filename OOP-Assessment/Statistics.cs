using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    public class Statistics
    {
        public int RoomsVisited { get; set; } = 0;
        public int MonstersDefeated { get; set; } = 0;

        public void ShowStats()
        {
            Console.WriteLine($"\n*** Game Stats ***");
            Console.WriteLine($"Rooms visited: {RoomsVisited}");
            Console.WriteLine($"Monsters defeated: {MonstersDefeated}");
        }
    }
}
