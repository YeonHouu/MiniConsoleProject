﻿using MiniTextRPG.Scenes;

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
        public static Player Player { get { return player; } }

        public static void Start()
        {
            // Scene 데이터 Directory
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Home", new HomeScene());
            sceneDic.Add("Room", new RoomScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("Forest", new ForestScene());

            // 게임 시작 시 처음 나올 Scene
            curScene = sceneDic["Title"];

            // 플레이어 인스턴스 생성
            player = new Player();

            // 콘솔에서 커버 숨김
            Console.CursorVisible = false;

            // 모든 아이템 인스턴스 생성
            Item.ItemMaker();
           
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
