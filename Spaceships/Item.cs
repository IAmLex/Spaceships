using System;
using System.Collections.Generic;
using System.Text;

namespace Spaceships
{
    class Item
    {
        public string name;

        public int id;

        public Item(string name = "Default item", int id = 0)
        {
            this.name   = name;
            this.id     = id;
        }
    }
}
