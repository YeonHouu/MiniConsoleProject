using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MiniTextRPG
{
   
    public class Player
    {
        private int maxHp;
        private int maxExp;

        public int Speed { get; set; }
        public int Attack { get; set; }
        public int Hp { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; }
        public Inventory Inventory { get; }

        public Player()
        {
            Hp = 100;
            Speed = 5;
            Attack = 10;
            Exp = 0;
            maxExp = 100;
            Level = 1;
            Inventory = new Inventory();
        }

        public void ExpUp(int exp)
        {
            Exp += exp;
            Console.WriteLine($"Exp {exp} 증가!");

            //레벨 업
            if (Exp >= maxExp)
            {
                Exp = exp % maxExp;
                Level++;
                Console.WriteLine($"레벨 업!");
                Console.WriteLine($"Lv.{Level-1} -> Lv.{Level}");
            }
        }

        public void SpeedUp(int speed)
        {
            Speed += speed;
            Console.WriteLine($"Speed {speed} 증가!");
        }

        public void HpUp(int hp)
        {
            Hp += hp;
            Console.WriteLine($"HP {hp} 증가!");

            // 오버 체력 방지
            if (Hp >= maxHp)
            {
                Hp = maxHp;
            }
        }
        public void AttackMonster(Monster monster)
        {
            monster.Hp -= Attack;
            Console.WriteLine($"{monster.Name}을(를) 공격했다.");
            if(monster.Hp <= 0)
            {
                monster.Hp = 0;
                monster.IsAlive = false;
                Console.WriteLine($"{monster.Name}이(가) 사망했다.");
                // 몬스터 dropItem 획득
                Game.Player.Inventory.AddItem(monster.DropItem);
                Console.WriteLine("전투에서 이겨서 기분이 좋다! 집으로 돌아간다 ♪");
            }
        }
    }
}
