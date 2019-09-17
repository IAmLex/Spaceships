using System;
using System.Collections.Generic;
using System.Text;

namespace Spaceships
{
    class Cargoship : Spaceship
    {
        public List<Item> storage;

        public int storageSpace;

        public Cargoship (string name = "Default cargoship", int health = 500, int storageSpace = 10, int accuracy = 3)
        {
            this.name           = name;

            this.health         = health;
            this.storageSpace   = storageSpace;
        }

        public string AddToStorage(Item item)
        {
            if (this.storage.Count <= storageSpace)
            {
                return $"{this.name} has no more storage left.";
            }
            else
            {
                this.storage.Add(item);

                return $"The item had been added to {this.name}'s storage.";
            }
        }

        public string DeleteItem(Item item)
        {
            if (storage.Contains(item))
            {
                if (storage.Remove(item))
                {
                    return $"{item.name} was succesfully from {this.name}.";
                }
                else
                {
                    return $"{item.name} could not be removed from {this.name}.";
                }
            }

            return $"{this.name} doesn't have this item.";
        }
    }
}
