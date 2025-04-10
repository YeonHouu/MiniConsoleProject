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
            Console.WriteLine($"[ {item.Name} ]을(를) 획득했다!");
            Console.WriteLine();
            Print();
            Console.WriteLine();
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
                    Console.WriteLine();
                    Console.WriteLine($"{item.Name} : {item.Description}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("*-----------------------------------------------------------------------*");

        }
    }
}
