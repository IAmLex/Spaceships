using System;
using System.Collections.Generic;
using System.Text;

namespace Spaceships
{
    class Spaceship
    {
        public string name;

        public int health;

        public Spaceship(string name = "Default spaceship", int health = 100)
        {
            this.name       = name;

            this.health     = health;
        }

        public int GetHit(int damage)
        {
            if (this.health - damage >= 0)
            {
                return this.health -= damage;
            }
            else
            {
                this.health = 0;
                return this.health;
            }
        }

    }
}
