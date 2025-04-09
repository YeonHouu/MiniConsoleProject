namespace MiniTextRPG.Scenes
{
    public class HomeScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("*---------------------------------------------------------------------*            *---     (=^‥^=)     ---*");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                                                                                           HP :  {Game.Player.Hp}       ");
            Console.WriteLine(); 
            Console.WriteLine($"                    아늑한 바구니 속에서 깨어났다...                                    SPEED :  {Game.Player.Speed}     ");
            Console.WriteLine("                         당신은 배가 고프다...                                                          ");
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
            if(isRoomDone == false)
            {
                Console.WriteLine(" 1. 마을로 간다.");
                Console.WriteLine(" 2. 숲으로로 간다.");
                Console.WriteLine(" 3. 바구니 속을 뒤져본다.");
                Console.WriteLine(" 4. 자도 자도 잠은 부족하다. 다시 잔다..");

            }
            // 모든 할 일 끝났으면 이후에 RoomScene 재방문 불가
            else if(isRoomDone == true)
            {
                Console.WriteLine(" 1. 마을로 간다.");
                Console.WriteLine(" 2. 숲으로로 간다.");
                Console.WriteLine(" 3. 자도 자도 잠은 부족하다. 다시 잔다..");
            }
        }
        public override void Result()
        {
            do
            {
                switch (inputKey)
                {
                    case ConsoleKey.D1:
                        isCorretInputKey = true;

                        if (Game.Player.Level < 2)
                        {
                            Console.WriteLine("세상 경험이 부족한 고양이는 함부로 나갔다간 무슨 일을 당할지 모른다...");
                            Console.WriteLine("나가기 전 준비를 하자.");
                        }
                        else
                        {
                            Console.WriteLine("마을로 이동합니다.");
                        }
                        break;

                    case ConsoleKey.D2:
                        isCorretInputKey = true;

                        if (Game.Player.Level < 2)
                        {
                            Console.WriteLine("세상 경험이 부족한 고양이는 함부로 나갔다간 무슨 일을 당할지 모른다...");
                            Console.WriteLine("나가기 전 준비를 하자.");
                        }
                        else
                        {
                            Console.WriteLine("숲으로 이동합니다.");
                        }
                        break;

                    case ConsoleKey.D3:
                        isCorretInputKey = true;

                        if(isRoomDone == false)
                        {
                            Console.WriteLine("바구니 안에 어떤 물건이 있는지 둘러보자.");
                        }
                        else
                        {
                            Console.WriteLine("당신은 무한한 잠의 굴레에 빠졌다..zz");
                        }
                        break;

                    case ConsoleKey.D4:
                        if (isRoomDone == false)
                        {
                            isCorretInputKey = true;
                            Console.WriteLine("당신은 무한한 잠의 굴레에 빠졌다..zz");
                        }
                        else
                        {
                            isCorretInputKey = false;
                            Console.WriteLine("잘못 입력 하셨습니다. 다시 입력해주세요...");
                            Console.WriteLine();
                            InputKey();
                        }
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
                    if (Game.Player.Level < 2)
                    {
                        Game.ChangeScene("Home");
                    }
                    else
                        Game.ChangeScene("Town");
                    break;
                case ConsoleKey.D2:
                    if (Game.Player.Level < 2)
                    {
                        Game.ChangeScene("Home");
                    }
                    else
                        Game.ChangeScene("Forest");
                    break;
                case ConsoleKey.D3:
                    if (isRoomDone == false)
                    {
                        Game.ChangeScene("Room");
                    }
                    else
                    {
                        Game.ChangeScene("Title");
                    }
                    break;
                case ConsoleKey.D4:
                    if (isRoomDone == false)
                    {
                        Game.ChangeScene("Title");
                    }
                    break;
            }
        }
    }
}
