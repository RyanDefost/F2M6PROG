using System;
using System.Collections.Generic;
using System.Text;

namespace PROG
{
    public enum Rarity
    {
        common,
        uncommon,
        rare,
        epic,
        legendary
    }

    abstract class Item
    {
        public string Name { get; private set; }
        public Rarity Rarity { get; private set; }

        public Item(string aName, Rarity rarity)
        {
            Name = aName;
        }

        public string GetName()
        {
            Console.WriteLine("F");
            return Name;
        }

        abstract public void use();
    }
}
