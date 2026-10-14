using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem_Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("          Adventure Game        ");
            Console.WriteLine("================================");
            
            Console.WriteLine();
            Console.WriteLine();

            Warrior war = new Warrior("Alex",80);
            Wizard wiz = new Wizard("Luna", 70);

            List<GameCharacter> characters = new List<GameCharacter>();

            characters.Add(war);
            characters.Add(wiz); 
            
            

            foreach (GameCharacter character in characters) {
                character.UseSpecialAbility();
                character.TakeDamage(10);
                Console.WriteLine();
                Console.WriteLine();
                character.Heal();
                Console.WriteLine();
                character.Heal(15);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            

            HealthPotion potion = new HealthPotion();
            potion.Collect();

            
            
            string amount = Console.ReadLine();
            potion.Use(wiz, amount);
        }
    }
}
