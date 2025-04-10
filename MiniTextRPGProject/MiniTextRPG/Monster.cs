namespace MiniTextRPG
{
    public class Monster
    {
        public string Name { get; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Speed { get; set; }
        public bool IsAlive { get; set; }

        public Monster(string name, int hp, int attack, int speed, bool isAlive)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
            Speed = speed;
            IsAlive = isAlive;
        }

        public void PrintInfo(Monster monster)
        {
            Console.WriteLine($"이름: {Name}, 체력: {Hp}, 공격력: {Attack}, 속도: {Speed}");
        }

        public void AttackPlayer()
        {
            if (IsAlive == true)
            {
                Game.Player.Hp -= Attack;
                Console.WriteLine($"{Name}(이)가 나를 공격했다.");
                if (Game.Player.Hp < 0)
                {
                    Game.Player.Hp = 0;
                    Console.WriteLine($"{Name}의 전투에서 졌다.. 회복을 위해 집으로 돌아간다... ");
                }
            }
        }

        // 몬스터 목록

        // #Forest - Fight
        public static Monster chicken => new Monster("야생의 닭", 50, 10, 1, true);
    }
}
