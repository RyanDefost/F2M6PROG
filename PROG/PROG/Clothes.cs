using System;
using System.Collections.Generic;
using System.Text;

namespace PROG
{
    class Clothes : Item
    {
        private string _fabric;
        public Clothes(string aName, Rarity rarity) : base(aName, rarity)
        {

        }
        public override void use()
        {
            Console.WriteLine("You equip the " + Name);
        }
    }
}
