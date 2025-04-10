using ConsoleRpg.cut;
using System.Data;

namespace ConsoleRpg
{
    public class Game
    {
        private static Dictionary<string, Basecut> cutDic;
        private static Basecut window;

        private static bool gameover;
        public static Player player;
        
        public static int DeathCount = 0; //죽은 횟수 카운트   
        public static void Start()
        { //게임의 초기설정
            gameover = false;
            //씬 설정
            cutDic = new Dictionary<string, Basecut>();
            cutDic.Add("Title", new Title());
            cutDic.Add("room1", new room01());
            cutDic.Add("room2", new room02());
            cutDic.Add("room3", new room03());
            cutDic.Add("room4", new room04());
            cutDic.Add("room5", new room05());
            cutDic.Add("room6", new room06());
            cutDic.Add("room7", new room07());
            //cutDic.Add("room8", new room08());
            //cutDic.Add("room9", new room09());
            //cutDic.Add("room10", new room10());
            //cutDic.Add("room11", new room11());
            //cutDic.Add("room12", new room12());
            //cutDic.Add("room13", new room13());
            //cutDic.Add("room14", new room14());
            //cutDic.Add("room15", new room15());
            //cutDic.Add("room16", new room16());
            //cutDic.Add("room17", new room17());
            //cutDic.Add("room18", new room18());
            //cutDic.Add("room19", new room19());
            //cutDic.Add("room20", new room20());
            //cutDic.Add("room21", new room21());
            //cutDic.Add("room22", new room22());
            //cutDic.Add("room23", new room23());
            //cutDic.Add("room24", new room24());
            //cutDic.Add("room25", new room25());




            player = new Player();
            player.Hp = 100;
            player.Attack = 10;
            player.Speed = 1.8f;
            player.Gold = 500;
            
            

            window = cutDic["Title"];
        }

        public static void Run()
        {
            Start();
            while (gameover == false)
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


        public static void Gameover(string reason)
        {// 죽을시 출력 런 가동을 중지시킴.
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("\r\n   ********      **     ****     **** ********     *******   **      ** ******** *******  \r\n  **//////**    ****   /**/**   **/**/**/////     **/////** /**     /**/**///// /**////** \r\n **      //    **//**  /**//** ** /**/**         **     //**/**     /**/**      /**   /** \r\n/**           **  //** /** //***  /**/*******   /**      /**//**    ** /******* /*******  \r\n/**    ***** **********/**  //*   /**/**////    /**      /** //**  **  /**////  /**///**  \r\n//**  ////**/**//////**/**   /    /**/**        //**     **   //****   /**      /**  //** \r\n //******** /**     /**/**        /**/********   //*******     //**    /********/**   //**\r\n  ////////  //      // //         // ////////     ///////       //     //////// //     // \r\n");
            Console.WriteLine("");
            Console.WriteLine(reason);
            Console.WriteLine("다시 하시겠습니까?");
            Console.WriteLine("↑.Retry?. ↓.Exit.");
            //해당 데스카운트 하나로만은 불가능 하고 각자 데스 적립치를 쌓아줬을때 발동 할수 있게 구현. 만약에 죽음으로 가는 경로에 카운트를 만들고
            // 그 카운트를 사용하여 각자 개체에 맞는 해금조건을 만들어준다.
            bool die2 = false;
            while (die2 == false)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            Resetstat();
                            DeathCount++;
                            //체력 /공 장비등등 초기화하기
                            //base();  베이스 함수를 만들어서 초기값을 지정하여 함수 출력.
                            die2 = true;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            gameover = true;
                            die2 = true;
                            break;
                        }

                }
            }
        }
        public static void End()
        { //게임의 종료

        }
        public static void Resetstat()
        { //게임
            player.Hp = 100;
            player.Attack = 10;
            player.Speed = 1.8f;
            player.Gold = 500;
            window = cutDic["Title"];
        }
        public static void PrintInfo()
        {
            Console.WriteLine("┌─────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│  플레이어                                                   │");
            Console.WriteLine("│                                                             │");
            Console.WriteLine("│    HP : {0}\tSpeed : {1}\tAttack : {2}\t Gold : {3}   │", player.Hp, player.Speed,player.Attack,player.Gold);
            Console.WriteLine("└─────────────────────────────────────────────────────────────┘");
            Console.WriteLine();
        }
        
        public static void HpPlus()
        {
            player.Hp++;
        }
        public static void HpMinus()
        {
            player.Hp--;
        }
        public static void AttackPlus()
        {
            player.Attack++;
        }
        public static void AttackMinus()
        {
            player.Attack--;
        }
        public static void SpeedPlus()
        {
            player.Speed++;
        }
        public static void SpeedMinus()
        {
            player.Speed--;
        }

        public static void useshop()
        {
            Shop shop = new Shop();
            shop.useshop();
        }
    }

}