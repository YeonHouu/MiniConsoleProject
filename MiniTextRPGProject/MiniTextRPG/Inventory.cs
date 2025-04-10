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
            inventory = new List<Item>();
        }

        public void AddItem(Item item)
        {
            inventory.Add(item);
        }

        public void Print()
        {
            Console.WriteLine("*--------------------------------인벤토리-------------------------------*");
            foreach (Item item in inventory)
            {
                if (inventory.Count == 0)
                {
                    Console.WriteLine("텅 ~");
                    return;
                }
                else
                {
                    Console.WriteLine($"{item.Name} : {item.Description}");
                }
            }
            Console.WriteLine("*---------------------------------------------------------------------*");

        }
    }
}
