using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem_Task6
{
    public abstract class GameCharacter
    {
        string _name;
        int  _health;
        public string Name { get { return _name; } set { _name = value; } }
        protected int Health {
            get {
                return _health;
            }
            set { if (value < 0)
                {
                    _health = 0;
                }
                else if (value > 100)
                {
                    _health= 100;
                }
                else { _health= value;}
            } 
        }

        public GameCharacter(string name , int health) {
            Name = name;
            Health = health;
        }

        public abstract void UseSpecialAbility();

        public virtual void TakeDamage(int amount) { }

        public void Heal()
        {
            if (Health <= 100) { 
                Health += 10;
            }
            Console.WriteLine($"{_name} heals 10 points");
            Console.WriteLine($"{_name}'s health : {Health}");

        }
        public void Heal(int amount)
        {
            if (Health <= 100)
            {
                Health += amount;
            }
            Console.WriteLine($"{_name} heals {amount} points");
            Console.WriteLine($"{_name}'s health : {Health}");
        }
    }
}
