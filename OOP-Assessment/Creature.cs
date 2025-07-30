using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    public abstract class Creature : IDamageable 
    {
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int AttackingPower { get; protected set; }

        public Creature(string name, int health, int attackingPower)
        {
            Name = name;
            Health = health;
            AttackingPower = attackingPower;
        }

        

        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name} took {amount} damage.");
            if (Health <= 0)
            {
                Console.WriteLine($"Name has been defeated!");
            }
        }

        public void Heal(int amount)
        {
            Health += amount;
            Console.WriteLine($"{Name} healed {amount} HP. Current health: {Health}");
        }

        public void IncreaseAttackingPower(int amount)
        {
            AttackingPower += amount;
            Console.WriteLine($"{Name}'s attack power increased by {amount}. New power: {AttackingPower}");
        }

        public void Attack(Creature target)
        {
            target.Health -= this.AttackingPower;
            Console.WriteLine($"{Name} attacks {target.Name} for {AttackingPower} damage!");
        }
    }
}
