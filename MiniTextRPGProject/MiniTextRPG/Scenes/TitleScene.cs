namespace MiniTextRPG.Scenes
{
    public class TitleScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*             (=^‥^=)              *");
            Console.WriteLine("*           고양이 RPG             *");
            Console.WriteLine("************************************");
        }
        public override void Choice()
        {
            Console.WriteLine("1. 게임시작");
            Console.WriteLine("2. 불러오기(미구현)");
            Console.WriteLine("3. 게임종료(미구현)");
        }
        public override void Result() { }

        public override void Wait() { }

        public override void NextScene()
        {
            switch (inputKey)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Home");
                    break;
            }
        }
    }
}
