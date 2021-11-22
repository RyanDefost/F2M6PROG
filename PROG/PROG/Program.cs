using System;
using System.Collections.Generic;

namespace PROG
{
    class Program
    {
        static void Main(string[] args)
        {
            Item shoe = new Item("p");
            Item apple = new Item("Sweet Apple");

            Inventory inventory = new Inventory();

            inventory.AadItem(shoe);
            inventory.AadItem(apple);

            Console.WriteLine(inventory.GetItems(0).Name);
            Console.WriteLine(inventory.GetItems(1).Name);
            //Console.WriteLine("Test");
        }
    }
}
