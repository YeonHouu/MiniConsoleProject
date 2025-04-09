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
            foreach (Item item in inventory)
            {
                if (inventory.Count == 0)
                {
                    Console.WriteLine("인벤토리에 아이템이 없습니다.");
                    return;
                }
                else
                {
                    Console.WriteLine(item.name);
                }
            }
        }
    }
}
