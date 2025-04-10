using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTextRPG
{
    public class Monster
    {
        public string Name { get; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Speed { get; set; }

        public Monster(string name, int hp, int attack, int speed)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
            Speed = speed;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"[몬스터] 이름: {Name}, 체력: {Hp}, 공격력: {Attack}, 속도: {Speed}");
        }

        public void TakeDamage(int damage)
        {
            Hp -= damage;
            if (Hp < 0) Hp = 0;
            Console.WriteLine($"{Name}이(가) {damage}의 피해를 입었습니다! 남은 체력: {Hp}");
        }

        // 몬스터 목록

        // #Forest - Fight
        public static Monster chicken => new Monster("야생의 닭", 50, 10, 1);
    }
}
