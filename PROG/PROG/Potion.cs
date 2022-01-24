using System;
using System.Collections.Generic;
using System.Text;

namespace PROG
{
    class Potion : Item
    {
        private string _effect;

        public Potion(string aName, Rarity rarity) : base(aName, rarity)
        {

        }

        public override void use()
        {
            Console.WriteLine("You drink the " + Name);
        }
    }
}
