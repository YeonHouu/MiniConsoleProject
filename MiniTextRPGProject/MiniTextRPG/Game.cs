using MiniTextRPG.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTextRPG
{
    class Game
    {
        private static Dictionary<string, Scene> sceneDic;

        //현재 콘솔 출력 중인 Scene
        private static Scene curScene;

        public static void Start()
        {
            //Scene 데이터 Directory
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());

            //게임 시작 시 처음 나올 Scene
            curScene = sceneDic["TitleScene"];
        }

        public static void Run()
        {

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
