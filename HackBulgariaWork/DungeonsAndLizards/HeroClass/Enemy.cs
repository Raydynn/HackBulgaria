using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroClass
{
    class Enemy
    {
        public static int Health { get; set; }
        public int Mana { get; set; }
        public int Damage { get; set; }

        private int currentHealth = Health;

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
        public int GetHealth()
        {
            return currentHealth;
        }
        public int GetMana()
        {
            return Mana;
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
            return mana;
        }
        //public int Attack()
        //{
        //    TODO
        //}
        public int TakeDamage(int damageTaken)
        {
            currentHealth = currentHealth - damageTaken;
            if (currentHealth < 0)
            {
                currentHealth = 0;
            }
            return currentHealth;
        }
    }
}
