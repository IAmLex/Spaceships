using System;
using System.Collections.Generic;
using System.Text;

namespace Spaceships
{
    class Fighter : Spaceship
    {
        public int guns;
        public int damage;
        public int accuracy;

        public Fighter(string name = "Default fighter", int health = 150, int guns = 5, int damage = 5, int accuracy = 8)
        {
            this.name = name;
            
            this.health = health;
            this.guns = guns;
            this.damage = damage;
            this.accuracy = accuracy;
        }
        public int Shoot()
        {
            if (this.health > 0)
            {
                return damage * guns;
            }
            else
            {
                return -1;
            }
        }

        public bool IsDead()
        {
            if (this.health > 0)
                return false;

            Console.WriteLine($"{this.name} is dead.");
            return true;
        }
    }
}
