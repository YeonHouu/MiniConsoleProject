namespace MiniTextRPG.Scenes.Forest
{
    class ForestLakeScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("*---------------------------------------------------------------------*            *---     (=^‥^=)     ---*");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                                                                                           HP :  {Game.Player.Hp}       ");
            Console.WriteLine();
            Console.WriteLine($"                     와 물고기 천국이다 ! !                                             SPEED :  {Game.Player.Speed}     ");
            Console.WriteLine("                          다 내꺼 ! ! !                                                           ");
            Console.WriteLine($"                                                                                          EXP :  {Game.Player.Exp}        ");
            Console.WriteLine();
            Console.WriteLine($"                                                                                        LEVEL :  {Game.Player.Level}      ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*---------------------------------------------------------------------*            *-----------------------*");
        }
        public override void Choice()
        {
            Console.WriteLine(" 1. 낚싯대를 사용한다 ");
            Console.WriteLine(" 2. 지금 낚시는 하고싶지 않다. 숲의 입구로 돌아간다...");
        }

        public override void Result()
        {
            do
            {
                switch (inputKey)
                {
                    case ConsoleKey.D1:
                        isCorretInputKey = true;

                        // 플레이어 인벤토리 아이템 유무 체크
                        if (Game.Player.Inventory.inventory.Contains(Item.fishPole) == false)
                        {
                            Game.Player.Inventory.Print();
                            Console.WriteLine("이런 [ 낚싯대 ]를 가지고 있지 않다...");
                            Console.WriteLine("낚시는 물 건너갔다..");
                            Console.WriteLine("숲의 입구로 돌아간다.");
                        }
                        break;

                    case ConsoleKey.D2:
                        isCorretInputKey = true;
                        break;

                    default:
                        isCorretInputKey = false;
                        Console.WriteLine("잘못 입력 하셨습니다. 다시 입력해주세요...");
                        Console.WriteLine();
                        InputKey();
                        break;
                }
            } while (isCorretInputKey == false);
        }

        public override void Wait()
        {
            if (isCorretInputKey == true)
            {
                Console.WriteLine("계속하려면 아무키나 입력하세요...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine();
            }
        }
        public override void NextScene()
        {
            switch (inputKey)
            {
                case ConsoleKey.D1:
                    if (Game.Player.Inventory.inventory.Contains(Item.fishPole) == false)
                    {
                        Game.ChangeScene("Forest");
                    }
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Forest");
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("Home");
                    break;
            }
        }
    }
}
