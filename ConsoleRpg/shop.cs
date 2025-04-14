using System.Reflection.Emit;

namespace ConsoleRpg
{
    class Shop 
    {

        //public enum shop { shoptitle,menu, buy,buyingcut }
        private Stack<string> shopStack;
        private int selectindex;
        public static Game game = new Game();

        public Shop()
        {
            shopStack = new Stack<string>();
        }
        // 상점의 스택화
        public void useshop()
        {
            shopStack.Push("shoptitle");
            while (shopStack.Count > 0)
            {
                Console.Clear();
                
                switch (shopStack.Peek())
                {
                    case "shoptitle": shoptitle(); break;
                    // 상점 타이틀 컷신


                    case "in": shopitem(); break;
                    //들어간다

                    case "Exit": shopStack.Pop(); break;
                        // 나간다
                        break;
                    case "buy":  buy(); break;  
                        // 구매 컷신
                        break;
                    
                    default:
                        break;
                }
            }
        }
        public void shoptitle()
        {
            Console.WriteLine("  ******** **      **   *******   ******* \r\n **////// /**     /**  **/////** /**////**\r\n/**       /**     /** **     //**/**   /**\r\n/*********/**********/**      /**/******* \r\n////////**/**//////**/**      /**/**////  \r\n       /**/**     /**//**     ** /**      \r\n ******** /**     /** //*******  /**      \r\n////////  //      //   ///////   //       ");
            Console.WriteLine();
            Console.Write("↑. In\t");
            Console.WriteLine("↓. Exit");

            ConsoleKey input = Console.ReadKey(true).Key; //키 입력을 대기한다.
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    shopStack.Push("in");
                    break;
                case ConsoleKey.DownArrow:
                    shopStack.Pop();
                    break;
                default:
                    break;
            }

        }
        public void shopitem()
        {
            Console.WriteLine("Buy Items");
            Console.WriteLine("↑.Speed Postion");
            Console.WriteLine("←.Attack Postion");
            Console.WriteLine("→.Expensive Sword");
            Console.WriteLine("↓.Back");
            ConsoleKey input = Console.ReadKey(true).Key; //키 입력을 대기한다.
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    {
                        
                        selectindex = 1;
                        shopStack.Push("buy");
                        break;
                    }
                case ConsoleKey.LeftArrow:
                    {
                        
                        selectindex = 2;
                        shopStack.Push("buy");
                        break;
                    }
                case ConsoleKey.RightArrow:
                    {
                        
                        selectindex = 3;
                        shopStack.Push("buy");
                        break;
                    }
                case ConsoleKey.DownArrow:
                    {
                        shopStack.Pop();
                        break;
                    }
                default:
                    break;
            }
        }
        public void buy()
        {if(selectindex == 1)
            {
                Console.WriteLine("Speed Postion");
                Console.WriteLine("Speed + 20%  Gold : 500");
                Console.WriteLine("Buying?? (yes)↑/(no)↓");
                ConsoleKey input = Console.ReadKey(true).Key; //키 입력을 대기한다.
                switch (input)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (Game.player.Gold >= 500)
                            {
                                Game.player.Gold -= 500;
                                Game.player.Speed *= 1.2f;
                                Console.WriteLine($" Speed Up :{Game.player.Speed} ");
                                Console.ReadKey(true);
                            }
                            else
                            {
                                Console.WriteLine("no Money T_T.");
                                Console.ReadKey(true);
                            }
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            shopStack.Pop();
                            break;
                        }
                    default:
                        break;
                }
            }
            else if (selectindex == 2)
            {
                Console.WriteLine("Attack Postion");
                Console.WriteLine("Attack + 20%  Gold : 500");
                Console.WriteLine("Buying?? (yes)↑/(no)↓");
                ConsoleKey input = Console.ReadKey(true).Key; //키 입력을 대기한다.
                switch (input)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (Game.player.Gold >= 500)
                            {
                                Game.player.Gold -= 500;
                                Game.player.Attack *= 1.2f;
                                Console.WriteLine($"Attack Up :{Game.player.Attack} ");
                                Console.ReadKey(true);
                            }
                            else
                            {
                                Console.WriteLine("no Money T_T.");
                                Console.ReadKey(true);
                            }
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            shopStack.Pop();
                            break;
                        }
                    default:
                        break;
                }
            }
            else if (selectindex == 3)
            {
                Console.WriteLine("Expensive Sword");
                Console.WriteLine("Attack + 20  Gold : 1000");
                Console.WriteLine("Buying?? (yes)↑/(no)↓");
                ConsoleKey input = Console.ReadKey(true).Key; //키 입력을 대기한다.
                switch (input)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (Game.player.Gold >= 1000)
                            {
                                Game.player.Gold -= 1000;
                                Game.player.Attack += 20;
                                Console.WriteLine($"Attack Up :{Game.player.Attack} ");
                                Console.ReadKey(true);
                            }
                            else
                            {
                                Console.WriteLine("no Money T_T.");
                                Console.ReadKey(true);
                            }
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            shopStack.Pop();
                            break;
                        }
                    default:
                        break;
                }
            }
           
            
        }



    }
}
