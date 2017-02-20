using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroClass
{
    public class Hero
    {
        public string Name { get; set; }
        public string HeroClass { get; set; }
        public static int Health { get; set; }
        public int Mana { get; set; }
        public int ManaRegenRate { get; set; }

        private int currentHealth = Health;

        public void KnownAs()
        {
            Console.WriteLine("{0} the {1}", Name, HeroClass);
        }
        public int GetHealth()
        {
            return currentHealth;
        }
        public int GetMana()
        {
            return Mana;
        }
        public bool IsAlive()
        {
            if (currentHealth <= 0)
	        {
		         return false;
	        }
            else
	        {
                return true;
        	}
        }
        public bool CanCast()
        {
            if (currentHealth > 0 && Mana > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int TakeDamage(int damageTaken)
        {
            currentHealth = currentHealth - damageTaken;
            if (currentHealth < 0)
	        {
		            currentHealth = 0;
	        }
            return currentHealth;
        }
        public bool TakeHealing(int healingPoints)
        {
            if (currentHealth <= 0)
            {
                return false;
            }
            else
            {
                currentHealth = currentHealth + healingPoints;
                if (currentHealth > Health)
                {
                    currentHealth = Health;
                }
                return true;
            }
        }
        public int TakeMana(int mana) 
        {
            return ManaRegenRate + mana;
        }

        public Hero(string name, string heroClass, int health, int mana, int manaRegenRate)
        {
            Name = name;
            HeroClass = heroClass;
            Health = health;
            Mana = mana;
            ManaRegenRate = manaRegenRate;
        }
    }
}
