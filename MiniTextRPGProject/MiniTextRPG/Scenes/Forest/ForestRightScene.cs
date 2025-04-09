using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTextRPG.Scenes.Forest
{
    class ForestRightScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("*---------------------------------------------------------------------*            *---     (=^‥^=)     ---*");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                                                                                           HP :  {Game.Player.Hp}       ");
            Console.WriteLine();
            Console.WriteLine($"                    고요한 숲속이다...                                    SPEED :  {Game.Player.Speed}     ");
            Console.WriteLine("                      숲에는 두갈래 길이 있다.                                                           ");
            Console.WriteLine($"                    어느 쪽으로 가볼까?                                                                      EXP :  {Game.Player.Exp}        ");
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
                    Game.ChangeScene("Town");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Town");
                    break;
            }
        }
    }
}
