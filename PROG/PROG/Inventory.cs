using System;
using System.Collections.Generic;
using System.Text;

namespace PROG
{
    class Inventory
    {
        private List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }

        public void AadItem(Item item)
        {
            _items.Add(item);
        }

        public Item GetItems(int NumbItem)
        {
            return _items[NumbItem];
        }
    }
}
