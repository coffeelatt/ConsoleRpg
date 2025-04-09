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

            window = cutDic["Title"];
        }

        public static void Run()
        {
            Start();
            while (gameover==false)
            {
                Console.Clear();
                
                window.Render();
                window.Input();
                window.Update();
                window.Result();

            }
            End();
        }
        public static void End()
        { //게임의 종료
            
        }



    }
}
