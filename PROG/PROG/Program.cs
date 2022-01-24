using System;
using System.Collections.Generic;

namespace PROG
{
    class Program
    {
        List<string> inputArrowInput = new List<string>()
        {
            "AskType",
            "AskName"
        };
        static void Main(string[] args)
        {
            Item BeginText = new Potion("beginText", Rarity.common);
            Item PoisonPotion = new Potion("Poison potion", Rarity.uncommon);
            Item MagicPotion = new Potion("Magic potion", Rarity.rare);
            Item MagicHat = new Clothes("Magic Hat", Rarity.legendary);

            Catalogue catalogue = new Catalogue();

            catalogue.AadItem(PoisonPotion);
            catalogue.AadItem(MagicPotion);
            catalogue.AadItem(MagicHat);

            catalogue.startItem = BeginText;

            
            //Console.WriteLine("");
            //Console.ReadLine();
            while (true)
            {
                catalogue.RunArrowInput("ItemList");
            }
        }
    }
}
