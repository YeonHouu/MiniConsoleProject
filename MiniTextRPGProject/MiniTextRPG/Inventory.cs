using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTextRPG
{
    class Inventory
    {
        public List<Item> inventory = new List<Item>(10);

        public void AddItem(Item item)
        {

        }

        public void PrintInventory(Item item)
        {
            foreach (Item items in inventory)
            {
                if(inventory == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(item.name);
                }
            }

        }

    }
}
