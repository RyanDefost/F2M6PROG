using System;
using System.Collections.Generic;
using System.Text;

namespace PROG
{
    class Item
    {
        public string Name { get; private set; }

        public Item(string name)
        {
            Name = name;
        }
    }
}
