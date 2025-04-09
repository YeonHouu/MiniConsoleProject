namespace MiniTextRPG.Scenes
{
    class RoomScene : Scene
    {
        private bool isChurDone = false;
        private bool isBallDone = false;
        public override void Render()
        {
            Console.WriteLine("*---------------------------------------------------------------------*            *---     (=^‥^=)     ---*");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                            바구니 안에서                                                   HP :  {Game.Player.Hp}       ");
            Console.WriteLine("");
            Console.WriteLine($"                        어제 먹고 남은 [ 츄르 ] !!!                                    SPEED :  {Game.Player.Speed}     ");
            Console.WriteLine("                      어디서 주워왔는지 모르겠는 [ 공 ]                                                         ");
            Console.WriteLine($"                                                                                           EXP :  {Game.Player.Exp}        ");
            Console.WriteLine("                             을 발견했다.");
            Console.WriteLine($"                          이제 무엇을 할까?                                               LEVEL :  {Game.Player.Level}      ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*---------------------------------------------------------------------*            *-----------------------*");

            if (isChurDone == true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("*---------------------------------------------------------------------*");
                Console.WriteLine();
                Console.WriteLine("                               남은 할 일");
                Console.WriteLine();
                Console.WriteLine("                                 공놀이");
                Console.WriteLine();
                Console.WriteLine("*---------------------------------------------------------------------*");
            }
            else if (isBallDone == true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("*---------------------------------------------------------------------*");
                Console.WriteLine();
                Console.WriteLine("                               남은 할 일");
                Console.WriteLine();
                Console.WriteLine("                                츄르 먹기");
                Console.WriteLine();
                Console.WriteLine("*---------------------------------------------------------------------*");
            }

        }
        public override void Choice()
        {
            if ((isChurDone == false) && (isBallDone == false))
            {
                Console.WriteLine(" 1. 츄르를 보고 지나치는 고양이가 있나? 당장 입에 넣는다.");
                Console.WriteLine(" 2. 운동 부족 고양이는 살아남을 수 없다. 공을 가지고 논다.");
                Console.WriteLine(" 3. 바구니에서 나온다.");
            }
            else if ((isChurDone == true) && (isBallDone == false))
            {

                Console.WriteLine(" 1. 운동 부족 고양이는 살아남을 수 없다. 공을 가지고 논다.");
                Console.WriteLine(" 2. 바구니에서 나온다.");
            }
            else if ((isChurDone == false) && (isBallDone == true))
            {
                Console.WriteLine(" 1. 츄르를 보고 지나치는 고양이가 있나? 당장 입에 넣는다.");
                Console.WriteLine(" 2. 바구니에서 나온다.");
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
                        if (isChurDone == false)
                        {
                            isChurDone = true;
                            Game.Player.Exp =+ 50;
                            Console.WriteLine("언제 먹어도 눈이 번쩍 떠지는 맛");
                            Console.WriteLine("츄 르 는 너 무 맛 있 어 ! ! !");
                            Console.WriteLine();
                            Console.ReadKey();
                            Console.WriteLine("          (=^OωO^=)         ");
                            Console.WriteLine("츄르는 고양이의 인생이다.");
                            Console.WriteLine("인생의 경험치가 조금 쌓인 기분이 든다.");
                            // TODO: 커서 위치 조정
                            Console.ReadKey();
                            Console.WriteLine();
                            Console.WriteLine("경험치 50 증가");

                            if((isChurDone == true) && (isBallDone == true))
                            {
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("바구니에는 더이상 볼 일이 없다...");
                                Console.WriteLine("방으로 돌아간다.");
                            }
               
                        }
                        else if ((isChurDone == true) && (isBallDone == false))
                        {
                            isBallDone = true;
                            Game.Player.Exp =+ 50;
                            Console.WriteLine("           (=^OωO^=)     ");
                            Console.WriteLine("공을 때리니 튀어올라 바구니 밖으로 나갔다.");
                            Console.WriteLine("멈춰라 ! ! !");
                            Console.ReadKey();
                            Console.WriteLine("헥 헥...");
                            Console.WriteLine("이리저리 피하는 공을 쫓다 보니 숨이 찬다..");
                            Console.WriteLine("다리 근육이 조금은 탄탄해진 기분이 든다.");
                            Console.ReadKey();
                            Console.WriteLine();
                            Console.WriteLine("경험치 50 증가");
                            Console.ReadKey();
                            Console.WriteLine();
                            Console.WriteLine("바구니에는 더이상 볼 일이 없다...");
                            Console.WriteLine("방으로 돌아간다.");
                        }
                        else if((isChurDone == true) && (isBallDone == true))
                        {
                            Console.WriteLine("바구니에는 더이상 볼 일이 없다...");
                            Console.WriteLine("방으로 돌아간다.");
                        }
                        break;


                    case ConsoleKey.D2:
                        isCorretInputKey = true;
                        if ((isChurDone == false) && (isBallDone == false))
                        {
                            isBallDone = true;
                            Game.Player.Exp =+ 50;
                            Console.WriteLine("           (=^OωO^=)     ");
                            Console.WriteLine("공을 때리니 튀어올라 바구니 밖으로 나갔다.");
                            Console.WriteLine("멈춰라 ! ! !");
                            Console.ReadKey();
                            Console.WriteLine("헥 헥...");
                            Console.WriteLine("이리저리 피하는 공을 쫓다 보니 숨이 찬다..");
                            Console.WriteLine("다리 근육이 조금은 탄탄해진 기분이 든다.");
                            Console.ReadKey();
                            Console.WriteLine();
                            Console.WriteLine("경험치 50 증가");
                        }
                        else if((isChurDone == false) || (isBallDone  == false))
                        {
                            Console.WriteLine("바구니에는 더이상 볼 일이 없다...");
                            Console.WriteLine("방으로 돌아간다.");
                        }

                        break;

                    case ConsoleKey.D3:
                        isCorretInputKey = true;
                        Console.WriteLine("바구니에는 더이상 볼 일이 없다...");
                        Console.WriteLine("방으로 돌아간다.");
                        break;

                    default:
                        isCorretInputKey = false;
                        Console.WriteLine("잘못 입력 하셨습니다. 다시 입력해주세요...");
                        Console.WriteLine();
                        InputKey();
                        break;
                }
            } while (isCorretInputKey == false);
            
            // 모든 할 일 끝났으면 이후에 RoomScene 재방문 불가 처리
            if ((isChurDone == true) && (isBallDone == true)) { isRoomDone = true; }
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
                    // TODO: Home으로 가는 조건 수정 필요
                    if ((isChurDone == true) && (isBallDone == false))
                    {
                        Game.ChangeScene("Room");
                    }
                    else
                    {
                        Game.ChangeScene("Home");
                    }
                    break;

                case ConsoleKey.D2:
                    if((isChurDone == false) || (isBallDone == true))
                    {
                        Game.ChangeScene("Room");
                    }
                    else
                    {
                        Game.ChangeScene("Home");
                    }
                    break;

                case ConsoleKey.D3:
                    Game.ChangeScene("Home");
                    break;
            }
        }
    }
}
