using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    //abstract base class for all in game items
    //implements ICollectible interface to mark that items can be collected by the player
    public abstract class Items : ICollectible
    {
        // The name of the item, accessible by this and any derived classes
        public string Name { get; protected set; }

        //Abstract method that defines how the item is used on the player
        public abstract void Use(Player player);
    }
}
