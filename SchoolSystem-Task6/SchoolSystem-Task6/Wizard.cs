using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem_Task6
{
    internal class Wizard : GameCharacter
    {
        public Wizard(string name, int health) : base(name, health)
        {
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine($"Wizard {Name} enters the game!");
            Console.WriteLine("The Wizard uses magic!");
        }

        public override void TakeDamage(int amount)
        {
            if (amount < 0) {
                amount = 0;
            }
            Health -= amount;
            Console.WriteLine($"{Name} takes {amount} damage.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }
    }
}
