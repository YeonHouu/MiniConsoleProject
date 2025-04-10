using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTextRPG.Scenes
{
    class EndScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("*---------------------------------------------------------------------*            *---     (=^‥^=)     ---*");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                                                                                           HP :  {Game.Player.Hp}       ");
            Console.WriteLine();
            Console.WriteLine($"                    아늑한 바구니 속이다...                                              SPEED :  {Game.Player.Speed}     ");
            Console.WriteLine("                    피곤한 당신은 잠이 든다...                                                          ");
            Console.WriteLine($"                                                                                          EXP :  {Game.Player.Exp}        ");
            Console.WriteLine();
            Console.WriteLine($"                                                                                        LEVEL :  {Game.Player.Level}      ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*---------------------------------------------------------------------*            *-----------------------*");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                      업데이트.... 예정.. 아마도....");
        }
        
        public override void Choice()
        {
            
        }

        public override void Result()
        {
            
        }

        public override void Wait()
        {
            
        }
        public override void NextScene()
        {
            
        }
    }
}
