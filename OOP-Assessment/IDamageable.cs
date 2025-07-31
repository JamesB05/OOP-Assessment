using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    //interface that represents anything that can take damage (Creatures)
    //any class that implements this has to provide its own TakeDamage method
    public interface IDamageable
    {
        // Method to reduce health or apply damage by a specified amount
        void TakeDamage(int amount);

    }
}
