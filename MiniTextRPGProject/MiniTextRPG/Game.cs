using MiniTextRPG.Scenes;

namespace MiniTextRPG
{
    class Game
    {
        private static bool gameOver;

        private static Dictionary<string, Scene> sceneDic;

        //현재 콘솔 출력 중인 Scene
        private static Scene curScene;

        private static Player player;
        public static Player Player { get { return player; } }

        public static void Start()
        {
            //Scene 데이터 Directory
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Home", new HomeScene());

            //게임 시작 시 처음 나올 Scene
            curScene = sceneDic["Title"];

            //플레이어 스텟 초기값
            player = new Player();
            player.Hp = 100;
            player.Speed = 10;
        }

        public static void Run()
        {
            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                Console.WriteLine();
                Console.WriteLine();
                curScene.Choice();
                curScene.InputKey();
                Console.WriteLine();
                curScene.Result();
                Console.WriteLine();
                curScene.Wait();
                curScene.NextScene();
            }
        }

        public static void End()
        {

        }

        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }
    }
}
