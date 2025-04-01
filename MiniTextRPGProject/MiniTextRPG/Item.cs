using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTextRPG
{
    public class Item
    {
        public string name;
        public int hp;
        public int speed;

        public Item(string name, int hp, int speed)
        {
            this.name = name;
            this.hp = hp;
            this.speed = speed;
        }
    }
}
