using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    public abstract class Items : ICollectible
    {
        public string Name { get; protected set; }
        public abstract void Use(Player player);
    }
}
