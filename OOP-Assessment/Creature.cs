using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment
{
    //abstract base class representing creatures found in the game
    //implements IDamageable so creatures can take damage
    public abstract class Creature : IDamageable 
    {
        //Name of Creature 
        //protected setter so derived classes only can change it
        public string Name { get; protected set; }

        //Health of Creature
        //also a protected setter
        public int Health { get; protected set; }

        //value of attacking power, determines damage dealt
        public int AttackingPower { get; protected set; }

        //constructor to initialise creature name, health and attacking power
        public Creature(string name, int health, int attackingPower)
        {
            Name = name;
            Health = health;
            AttackingPower = attackingPower;
        }

        //implementation of TakeDamage from IDamageable interface
        //reduces health by specified amount
        //if health falls to or below zero, announces the creature has been defeated

        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name} took {amount} damage.");
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} has been defeated!");
            }
        }

        //method to heal creature by increasing health and reporting new total
        public void Heal(int amount)
        {
            Health += amount;
            Console.WriteLine($"{Name} healed {amount} HP. Current health: {Health}");
        }

        //increases creature attacking power by aspecified amount
        public void IncreaseAttackingPower(int amount)
        {
            AttackingPower += amount;
            Console.WriteLine($"{Name}'s attack power increased by {amount}. New power: {AttackingPower}");
        }

        //basic attack method that reduces target health by creatures attacking power
        public void Attack(Creature target)
        {
            target.Health -= this.AttackingPower;
            Console.WriteLine($"{Name} attacks {target.Name} for {AttackingPower} damage!");
        }
    }
}
