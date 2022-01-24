using System;
using System.Collections.Generic;
using System.Text;

namespace PROG
{
    class Catalogue
    {
        private List<Item> _items;
        public Item startItem { get; set; }
        public Item currentItem { get; private set; }

        private int _index = 0;

        public Catalogue()
        {
            _items = new List<Item>();
        }

        public void AadItem(Item item)
        {
            _items.Add(item);
        }

        public List<Item> GetItems()
        {
            return _items;
        }
        

        public void RunArrowInput(string MenuName)
        {
            if (MenuName == "ItemList")
            {
                if(currentItem == null)
                {
                    currentItem = startItem;
                }
                Console.WriteLine($"the Item is: {currentItem.Name}");
                for (int i = 0; i < _items.Count; i++)
                {
                    Console.WriteLine($"{i}: {_items[i].Name}");
                    if(i == _index)
                    {
                        Console.Write("-->");
                        Console.Write($"\t{_items[i].Name}\n");
                    }
                }
            }
            
            if (MenuName == "addRemove")
            {
                string[] addRemove = {"add","remove"};
                Console.WriteLine("add/remove");
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine(addRemove[i]);
                    if (i == _index)
                    {
                        Console.Write("-->");
                        Console.Write($"\t{addRemove[i]}\n");
                    }
                }
            }

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    if(_index == 0)
                    {
                        _index = _items.Count - 1;
                    }
                    else
                    {
                        _index--;
                    }
                    break;

                case ConsoleKey.DownArrow:
                    if (_index < _items.Count - 1)
                    {
                        _index++;
                    }
                    else
                    {
                        _index = 0;
                    }
                    break;

                case ConsoleKey.Enter:
                    if (MenuName == "ItemList")
                    {
                        currentItem = _items[_index];
                    }
                    _index = 0;
                    break;
            }
            Console.Clear();
        }
    }
}
