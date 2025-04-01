using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTextRPG.Scenes
{
    public class HomeScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("*                    (=^‥^=)                    *");
            Console.WriteLine();
            Console.WriteLine(" 아늑한 바구니 속에서 깨어났다... ");
            Console.WriteLine(" 당신은 배가 고프다...  ");
            Console.WriteLine();
            Console.WriteLine("*                                               *");
        }
        public override void Choice()
        {
            Console.WriteLine("1. 바구니 속을 뒤져본다.");
            Console.WriteLine("2. 마을로 간다.");
            Console.WriteLine("3. 숲으로 간다.");
            Console.WriteLine("4. 자도 자도 잠은 부족하다. 다시 잔다.");
        }
        public override void Result() 
        {
            switch (inputKey)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("");
                    break;
            }
        }

        public override void Wait() { }

        public override void NextScene()
        {
            switch (inputKey)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("");
                    break;
                case ConsoleKey.D4:
                    Game.ChangeScene("Title");
                    break;
                default:
                    Console.WriteLine("잘못 입력 하셨습니다. 다시 입력해주세요.");
                    break;
            }
        }
    }
}
