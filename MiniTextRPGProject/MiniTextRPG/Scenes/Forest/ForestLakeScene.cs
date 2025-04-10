using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine($"                 오른쪽 숲으로 들어오니 눈앞에 큰 호수가 보인다...                                    SPEED :  {Game.Player.Speed}     ");
            Console.WriteLine("                      물고기가 많을지도 모른다!                                                           ");
            Console.WriteLine($"                       기다려 물고기야 ! !                                                              EXP :  {Game.Player.Exp}        ");
            Console.WriteLine();
            Console.WriteLine($"                                                                                        LEVEL :  {Game.Player.Level}      ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*---------------------------------------------------------------------*            *-----------------------*");
        }
            public override void Choice()
        {
            Console.WriteLine(" 1. 왼쪽");
            Console.WriteLine(" 2. 오른쪽");
            Console.WriteLine(" 3. 집으로 돌아간다...");
        }

        public override void Result()
        {
            do
            {
                switch (inputKey)
                {
                    case ConsoleKey.D1:
                        isCorretInputKey = true;
                        break;

                    case ConsoleKey.D2:
                        isCorretInputKey = true;
                        break;

                    case ConsoleKey.D3:
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
                    Game.ChangeScene("ForestLeft");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("ForestRight");
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("Home");
                    break;
            }
        }
    }
}
