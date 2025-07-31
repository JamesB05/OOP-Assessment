using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    //interface for items that can be collected and used by the player
    //must define how items are used
    public interface ICollectible
    {
        //method to apply item effect to player character
        void Use(Player player);

    }
}
