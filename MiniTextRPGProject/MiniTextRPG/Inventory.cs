using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTextRPG
{
    public class Inventory
    {
        public List<Item> inventory;

        public Inventory()
        {
            inventory = new List<Item>(5);
        }

        public void AddItem(Item item)
        {
            inventory.Add(item);
        }

        public void Print()
        {
            foreach (Item items in inventory)
            {
                if(inventory == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(items.name);
                }
            }
        }
    }
}
