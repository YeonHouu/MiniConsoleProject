using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTextRPG.Scenes
{
    public abstract class Scene
    {
        protected ConsoleKey inputKey;

        //해당 Scene 상황 설명 텍스트
        public abstract void Render();

        //해당 Scene 선택지
        public abstract void Choice();

        //해당 Scene 선택지 결과
        public abstract void Result();

        //해당 Scene 선택지 결과에 따른 다음 Scene
        public abstract void NextScene();

        //key 입력
        public void InputKey()
        {
            inputKey = Console.ReadKey(true).Key;
        }
    }
}
