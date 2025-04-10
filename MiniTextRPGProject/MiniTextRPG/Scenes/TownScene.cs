namespace MiniTextRPG.Scenes
{
    public class TownScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("*---------------------------------------------------------------------*            *---     (=^‥^=)     ---*");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                                                                                        HP :  {Game.Player.Hp}       ");
            Console.WriteLine();
            Console.WriteLine($"                        마을에 도착했다                                                SPEED :  {Game.Player.Speed}     ");
            Console.WriteLine("                          무엇을 할까?                                                                                  ");
            Console.WriteLine($"                                                                                        EXP :  {Game.Player.Exp}        ");
            Console.WriteLine();
            Console.WriteLine($"                                                                                        LEVEL :  {Game.Player.Level}      ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*---------------------------------------------------------------------*            *-----------------------*");
        }
        public override void Choice()
        {
            Console.WriteLine(" 1. 잡화점으로 간다.");
            Console.WriteLine(" 2. 생선 가게로 간다.");
            Console.WriteLine(" 3. 장식품 가게로 간다.");
            Console.WriteLine(" 4. 집으로 돌아간다.");
        }

        public override void Result()
        {
            do
            {
                switch (inputKey)
                {
                    case ConsoleKey.D1:
                        isCorretInputKey = true;
                        Console.WriteLine("잡화점으로 간다...");

                        break;

                    case ConsoleKey.D2:
                        isCorretInputKey = true;
                        if (Game.Player.Level < 5)
                        {
                            Console.WriteLine("큰 개가 가게 앞을 지키고 있다...");
                            Console.WriteLine("개와 대면할 엄두가 나지 않는다..");
                            Console.WriteLine("내공을 더 쌓고 오자...");
                        }
                        else
                        {
                            Console.WriteLine("장식품 가게로 간다...");
                        }
                        break;

                    case ConsoleKey.D3:
                        isCorretInputKey = true;
                        if (Game.Player.Level < 5)
                        {
                            Console.WriteLine("아직 인생의 경험이 부족하다...");
                            Console.WriteLine("장식품의 아름다움을 느끼려면 수행이 더 필요하다.");
                        }
                        else
                        {
                            Console.WriteLine("장식품 가게로 간다...");
                        }
                        break;

                    case ConsoleKey.D4:
                        isCorretInputKey = true;

                        Console.WriteLine("집으로 돌아간다...");
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
                    Game.ChangeScene("ItemShop");
                    break;

                case ConsoleKey.D2:
                    if (Game.Player.Level < 5)
                    {
                        Game.ChangeScene("Town");
                    }
                    else
                    {
                        Game.ChangeScene("FishStore");
                    }
                    break;

                case ConsoleKey.D3:
                    if (Game.Player.Level < 5)
                    {
                        Game.ChangeScene("Town");
                    }
                    else
                    {
                        Game.ChangeScene("InteriorShop");
                    }
                    break;

                case ConsoleKey.D4:
                    Game.ChangeScene("Home");
                    break;
            }
        }
    }
}
