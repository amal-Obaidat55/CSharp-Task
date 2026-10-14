using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem_Task6
{
    internal class Warrior : GameCharacter
    {
       
        public Warrior(string name, int health) : base(name, health)
        {
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine($"Warrior {Name} enters the game!");
            Console.WriteLine("The Warrior attacks with a sword!");
        }

        public override void TakeDamage(int amount)
        {
            amount -= 2;
            if (amount < 0)
            {
                amount = 0;
            }
            Health -= amount;
            Console.WriteLine($"{Name} takes {amount} damage.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }
       
    }
}
