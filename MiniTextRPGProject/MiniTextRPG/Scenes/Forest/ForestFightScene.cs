using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTextRPG.Scenes.Forest
{
    class ForestFightScene: Scene
    {
        public override void Render()
        {
            Console.WriteLine("*---------------------------------------------------------------------*            *---     (=^‥^=)     ---*");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                                                                                           HP :  {Game.Player.Hp}       ");
            Console.WriteLine();
            Console.WriteLine($"                                                                                SPEED :  {Game.Player.Speed}     ");
            Console.WriteLine($"                    {Game.Chicken.Name}이랑 싸운다!                                                                     ");
            Console.WriteLine($"                                                                                     EXP :  {Game.Player.Exp}        ");
            Console.WriteLine();
            Console.WriteLine($"                                                                                        LEVEL :  {Game.Player.Level}      ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*---------------------------------------------------------------------*            *-----------------------*");

            //Game.Monster.PrintInfo(Game.Chicken);
            
        }
        public override void Choice()
        {
            Console.WriteLine(" 1. 냥냥펀치");
            Console.WriteLine(" 2. 힘들다.. 도망간다...");
        }
        public override void Result()
        {
            do
            {
                switch (inputKey)
                {
                    case ConsoleKey.D1:
                        Game.Player.AttackMonster(Game.Chicken);
                        Game.Chicken.AttackPlayer();
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
                    if(Game.Chicken.IsAlive == false)
                    {
                        Game.ChangeScene("Home");
                    }
                    else
                    {
                        Game.ChangeScene("ForestFight");
                    }
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Forest");
                    break;
            }
        }
    }
}
