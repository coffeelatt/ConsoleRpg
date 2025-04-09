using ConsoleRpg.cut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg
{
    public class Game
    {
        private static Dictionary<string, Basecut> cutDic;
        private static Basecut window;

        private static bool gameover;

        public static void Start()
        { //게임의 초기설정
        gameover=false;
            //씬 설정
            cutDic = new Dictionary<string, Basecut>();
            cutDic.Add("Title", new Title());
            cutDic.Add("room1", new room01());
            cutDic.Add("room2", new room02());
            cutDic.Add("room3", new room03());
            cutDic.Add("room4", new room04());


            window = cutDic["Title"];
        }

        public static void Run()
        {
            Start();
            while (gameover==false)
            {
                Console.Clear(); //게임   화면을 지운다.
                //게임의 각종 처리

                window.Render();
                window.Input();
                window.Update();
                window.Result();

            }
            End();
        }

        public static void ChangeScene(string sceneName)
        { //씬을 변경한다.
            if (cutDic.ContainsKey(sceneName))
            {
                window = cutDic[sceneName];
            }
            else
            {
                Console.WriteLine("Invalid scene name.");
            }
        }
        public static void End()
        { //게임의 종료
            
        }



    }
}
