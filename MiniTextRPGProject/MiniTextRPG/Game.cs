using MiniTextRPG.Scenes;
using MiniTextRPG.Scenes.Forest;
using MiniTextRPG.Scenes.Town;
using MiniTextRPG;
using System.Reflection.Metadata.Ecma335;

namespace MiniTextRPG
{
    class Game
    {
        private static bool gameOver;

        private static Dictionary<string, Scene> sceneDic;

        // 현재 콘솔 출력 중인 Scene
        private static Scene curScene;

        public Scene CurScene { get { return curScene; } set { curScene = value; } }

        private static Player player;
        private static Monster chicken;
        public static Monster Chicken { get { return chicken; } }
        public static Player Player { get { return player; } }
        public static Monster Monster { get; }

        public static void Start()
        {
            // Scene 데이터 Directory
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Home", new HomeScene());
            sceneDic.Add("Room", new RoomScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("Forest", new ForestScene());
            sceneDic.Add("ItemShop", new ItemShopScene());
            sceneDic.Add("FishStore", new FishStoreScene());
            sceneDic.Add("InteriorShop", new InteriorShopScene());
            sceneDic.Add("ForestLeft", new ForestLeftScene());
            sceneDic.Add("ForestRight", new ForestRightScene());
            sceneDic.Add("ForestFight", new ForestFightScene());
            sceneDic.Add("ForestLake", new ForestLakeScene());
            sceneDic.Add("End", new EndScene());

            // 게임 시작 시 처음 나올 Scene
            curScene = sceneDic["Title"];

            // 플레이어 인스턴스 생성
            player = new Player();
            chicken = Monster.chicken;

            // 콘솔에서 커버 숨김
            Console.CursorVisible = false;
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
