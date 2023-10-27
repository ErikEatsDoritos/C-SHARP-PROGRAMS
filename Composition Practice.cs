using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace composition
{
    internal class Program
    {
        class player
        {
            private stats _stats;
            public player(int maxhealth)
            {
                this._stats = new stats(maxhealth,25);
            }
            public void TakeDamage(int dmg)
            {
                this._stats.ReduceHealth(dmg);
            }
            public void Heal(int heal)
            {
                this._stats.IncreaseHealth(heal);
            }
            public int GetHealth()
            {
                return this._stats.GetHealth();
            }
        }
        class stats
        {
            private int _currentHealth;
            private int _maxHealth;
            private int _armor;

            public stats(int maxhealth, int armor) { 
                this._armor = armor;
                this._maxHealth = maxhealth;
                this._currentHealth = maxhealth;
            }

            public int GetHealth()
            {
                return _currentHealth;
            }
            public void ReduceHealth(int health)
            {
                int potentialhp = this._currentHealth - ((_armor / 100) * health);
                if(potentialhp > 0)
                {
                    this._currentHealth -= health;
                }
                
            }
            public void IncreaseHealth(int health) {
                int potentialhp = this._currentHealth;
                if (potentialhp <= _maxHealth)
                {
                    this._currentHealth += health;
                }


                
            }
        }
        static void Main(string[] args)
        {
            player erik = new player(10);
            stats s = new stats(25, 100);
            s.ReduceHealth(100);
            s.IncreaseHealth(100);
            Console.WriteLine(s.GetHealth());
            Console.WriteLine(erik.GetHealth());
            erik.TakeDamage(20);
            Console.WriteLine(erik.GetHealth());
            erik.Heal(20);
            Console.WriteLine(erik.GetHealth());












            Console.ReadLine();




        }
    }
}
