using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTextRPG
{
    class ItemBuilder
    {
        public string name;
        public string description;
        public int hp;
        public int speed;
        public ConsoleColor color;

        public ItemBuilder()
        {
            name = "아이템명";
            description = "아이템 설명";
            hp = 0;
            speed = 0;
            color = ConsoleColor.White;
        }
        
        public Item Build()
        {
            Item item = new Item();
            item.name = name;
            item.description = description;
            item.hp = hp;
            item.speed = speed;
            item.color = color;
            return item;
        }

        public ItemBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public ItemBuilder SetDescription(string description)
        {
            this.description = description;
            return this;
        }

        public ItemBuilder SetHp(int hp)
        {
            this.hp = hp;
            return this;
        }

        public ItemBuilder SetSpeed(int speed)
        {
            this.speed = speed;
            return this;
        }

        public ItemBuilder SetColor(ConsoleColor color)
        {
            this.color = color;
            return this;
        }
    }
}
