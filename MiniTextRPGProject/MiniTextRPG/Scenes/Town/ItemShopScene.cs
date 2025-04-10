namespace MiniTextRPG.Scenes.Town
{
    class ItemShopScene : Scene
    {
        public override void Render()
        {
            if (isItemShopDone == false)
            {
                Console.WriteLine("*---------------------------------------------------------------------*            *---     (=^‥^=)     ---*");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"                   잡화점 매대가 잘 보이는 위치에 앉았다..                                  HP :  {Game.Player.Hp}       ");
                Console.WriteLine("                              다행이다.. ");
                Console.WriteLine($"                         주인은 졸고있다...                                             SPEED :  {Game.Player.Speed}     ");
                Console.WriteLine("");
                Console.WriteLine($"                          지금이 기회다 !                                                 EXP :  {Game.Player.Exp}        ");
                Console.WriteLine("");
                Console.WriteLine($"                        어떤 물건을 가져갈까?                                            LEVEL :  {Game.Player.Level}      ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("*---------------------------------------------------------------------*            *-----------------------*");
            }
            else
            {
                Console.WriteLine("*---------------------------------------------------------------------*            *---     (=^‥^=)     ---*");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"                                                                                        HP :  {Game.Player.Hp}       ");
                Console.WriteLine("");
                Console.WriteLine($"                주인이 두 눈을 시퍼렇게 뜨고 가게 앞에 서있다...                     SPEED :  {Game.Player.Speed}     ");
                Console.WriteLine("");
                Console.WriteLine($"                        물건을 가져가긴 힘들어 보인다.                                EXP :  {Game.Player.Exp}        ");
                Console.WriteLine("");
                Console.WriteLine($"                                                                                    LEVEL :  {Game.Player.Level}      ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("*---------------------------------------------------------------------*            *-----------------------*");
            }
        }
        public override void Choice()
        {
            if (isItemShopDone == false)
            {
                Console.WriteLine(" 1. 몇 달째 그 자리 그대로인 생선캔");
                Console.WriteLine(" 2. 부실해보이는 낚시대");
                Console.WriteLine(" 3. 착한 고양이는 남의 물건을 훔치지 않는다. 마을로 돌아간다...");
            }
            else
            {
                Console.WriteLine(" 1. 아쉽지만 마을로 돌아간다...");
            }
        }

        public override void Result()
        {
            if (isItemShopDone == false)
            {
                do
                {
                    switch (inputKey)
                    {
                        case ConsoleKey.D1:
                            isCorretInputKey = true;
                            isItemShopDone = true;
                            Console.WriteLine("매대 맨 앞에 진열된 생선캔을 노린다...");
                            Console.WriteLine("맹수(?)의 움직임으로...");
                            Console.WriteLine("점 프 ! ! !");
                            Console.ReadKey();
                            Console.WriteLine();
                            Console.WriteLine("        (=^>ω<^=)        ");
                            Console.WriteLine();
                            Console.WriteLine("아싸! 생선캔은 이제 내꺼다!");
                            Console.WriteLine("주인은 아직도 세상모르게 졸고 있다.");
                            Console.WriteLine("가벼운 발걸음으로 마을으로 향한다 ♪");
                            Game.Player.Inventory.AddItem(Item.fishCan);

                            break;

                        case ConsoleKey.D2:
                            isCorretInputKey = true;
                            isItemShopDone = true;
                            if (Game.Player.Level < 3)
                            {
                                Console.WriteLine("살금 살금 진열된 물건을 피해 낚시대로 걸어간다..");
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("낚시대 대를 입에 무는 순간!");
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("        (=^;ω;^=)        ");
                                Console.WriteLine();
                                Console.WriteLine("세상에 생각보다 너무 무겁다!");
                                Console.WriteLine("물었던 낚시대를 그대로 놓쳤다...");
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("낚시대가 나뒹구는 소리를 듣고 주인이 깨버렸다...");
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("잡히면 죽음이다 ! ! 전속력으로 마을로 도망친다 ! ! !");
                            }
                            else
                            {
                                Console.WriteLine("살금 살금 진열된 물건을 피해 낚시대로 걸어간다..");
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("낚시대 대를 입에 무는 순간");
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("        (=^>ω<^=)        ");
                                Console.WriteLine();
                                Console.WriteLine("어라? 츄르만큼 가볍다!");
                                Console.WriteLine("이제 너무나도 사랑하는 물고기를 잡을 수 있을지도 모른다 ! ! !");
                                Console.WriteLine("가벼운 발걸음으로 마을으로 향한다 ♪");
                                Game.Player.Inventory.AddItem(Item.fishPole);

                            }
                            break;

                        case ConsoleKey.D3:
                            isCorretInputKey = true;
                            Console.WriteLine("마을로 돌아간다...");
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
                case ConsoleKey.D2:
                case ConsoleKey.D3:
                    Game.ChangeScene("Town");
                    break;
            }
        }
    }
}
