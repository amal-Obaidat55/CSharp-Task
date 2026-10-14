using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem_Task6
{
    internal class HealthPotion : ICollectible
    {
        public void Collect()
        {
            Console.WriteLine("Health Potion collected!");
        }
        public void Use(GameCharacter character, string amountText) {
            try
            {
                int newAmount = Convert.ToInt32(amountText);
                character.Heal(newAmount);
            }
            catch (Exception ex) { Console.WriteLine("Invalid input! Please enter a number"); }
            
        }

    }
}
