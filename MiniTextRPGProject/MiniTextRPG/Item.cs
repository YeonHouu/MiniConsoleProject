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
        public string name;
        public string description;
        public int hp;
        public int speed;
        public ConsoleColor color;

        // 아이템 목록
        public static void ItemMaker()
        {
            // #Town - 잡화점
            ItemBuilder fishCanBuilder = new ItemBuilder();
            fishCanBuilder
                .SetName("생선 통조림")
                .SetDescription("매일 매대에 놓아져 있는 평범한 생선 통조림.")
                .SetHp(10)
                .SetSpeed(1)
                .SetColor(ConsoleColor.Cyan);
            
            Item fishCan = fishCanBuilder.Build();

            ItemBuilder fishPollBuilder = new ItemBuilder();
            fishPollBuilder
                .SetName("낚시대")
                .SetDescription("긴 막대기에 줄이 달려있다.")
                .SetHp(0)
                .SetSpeed(0)
                .SetColor(ConsoleColor.Cyan);

            Item fishpoll = fishPollBuilder.Build();


            // #Town - 생선가게
            ItemBuilder fish_1Builder = new ItemBuilder();
            fish_1Builder
                .SetName("생선")
                .SetDescription("도미, 농어, 넙치, 가자미, 대구")
                .SetHp(20)
                .SetSpeed(2)
                .SetColor(ConsoleColor.Cyan);
            
            Item fish_1 = fish_1Builder.Build();
            
            // #Town - 장식품 가게
            ItemBuilder blueOrnamentBuilder = new ItemBuilder();
            blueOrnamentBuilder
                .SetName("하늘색 풍경")
                .SetDescription("하늘색 유리 풍경. 풍판 바람에 흔들릴 때마다 좋은 소리가 난다.")
                .SetHp(0)
                .SetSpeed(10)
                .SetColor(ConsoleColor.Cyan);
            Item blueOrnament = blueOrnamentBuilder.Build();

            ItemBuilder purpleOrnamentBuilder = new ItemBuilder();
            purpleOrnamentBuilder
                .SetName("보라색 풍경")
                .SetDescription("보라색 유리 풍경. 풍판에 깃털이 달려 나의 눈길을 사로잡는다.")
                .SetHp(0)
                .SetSpeed(30)
                .SetColor(ConsoleColor.Magenta);
            Item purpleOrnament = purpleOrnamentBuilder.Build();

            // #Forest
            ItemBuilder chickenMeatBuilder = new ItemBuilder();
            chickenMeatBuilder
                .SetName("닭고기")
                .SetDescription("고기다 ! 고기 !")
                .SetHp(30)
                .SetSpeed(3)
                .SetColor(ConsoleColor.Cyan);
            Item chickenMeat = chickenMeatBuilder.Build();
        }
    }
}
