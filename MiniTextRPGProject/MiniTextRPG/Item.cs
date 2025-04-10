using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTextRPG
{
    public class Item
    {
        public string Name { get; }
        public string Description { get; }
        public int Hp { get; }
        public int Speed { get; }
        public ConsoleColor Color { get; set; }

        public Item(string name, string description, int hp, int speed, ConsoleColor color)
        {
            Name = name;
            Description = description;
            Hp = hp;
            Speed = speed;
            Color = color;
        }

        // 아이템 목록

        // #Town - 잡화점
        public static Item fishPole => new Item("낚싯대", "긴 막대기에 줄이 달려있다.", 0, 0, ConsoleColor.Cyan);
        public static Item fishCan => new Item("생선 통조림", "매일 매대에 놓여져 있는 평범한 생선 통조림.", 10, 1, ConsoleColor.Cyan);

        // #Town - 생선가게
        public static Item fish => new Item("생선", "농어", 20, 2, ConsoleColor.Cyan);

        // #Town - 장식품가게
        public static Item blueOrnament => new Item("하늘색 풍경", "하늘색 유리 풍경. 풍판 바람에 흔들릴 때마다 좋은 소리가 난다.", 0, 10, ConsoleColor.Cyan);
        public static Item purpleOrnament => new Item("보라색 풍경", "보라색 유리 풍경. 풍판에 깃털이 달려 나의 눈길을 사로잡는다.", 0, 30, ConsoleColor.Magenta);

        // #Forest - Fight
        public static Item chickenMeat => new Item("닭고기", "고기다 ! 고기 !", 30, 3, ConsoleColor.Cyan);
    }
}
