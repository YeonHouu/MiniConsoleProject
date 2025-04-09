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
        private int speed;
        private int hp;
        private int maxHp;
        private int exp;
        private int maxExp;
        private int level;
        private Inventory inventory;

        private string playerLocation;
        public int Speed { get { return speed; } set { speed = value; } }
        public int Hp { get { return hp; } set { hp = value; } }
        public int Exp { get { return exp; } set { exp = value; } }
        
        public int Level { get { return level; } set { level = value; } }
        public Inventory Inventory { get { return inventory; } }

        public Player()
        {
            Hp = 100;
            Speed = 10;
            Exp = 0;
            maxExp = 100;
            Level = 1;
            inventory = new Inventory();
        }

        public void ExpUp(int exp)
        {
            Exp += exp;
            Console.WriteLine($"Exp {exp} 증가!");

            //레벨 업
            if (Exp == maxExp)
            {
                Exp = 0;
                level++;
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

    }
}
