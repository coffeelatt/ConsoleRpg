﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg.cut
{
    public class room01 : Basecut

    { 
        private ConsoleKey input;
        public override void Render()
        {
            //앞 ,우 , back
            Console.WriteLine(";================================================================================================*--\r\n-@;!*;!*;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;**;!*;;=---\r\n-@;;;;;;!;**;**!*******************************************************************!:;;,*;;;;;;;=---\r\n-@;;;;;;!;;;;;;;*$!**********************************************************!=*,       *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;!*=#===============================================$$!;..           *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;;*;;;!*!*$==================================$$!!*!;;;;;             *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;;*;;;;;;;;!                                ~;;;;;;;;;;;             *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;;*;;;;;;;;!                                ~;;;;;;;;;;;             *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;;*;;;;;;;;!                                ~;;;;;;;;;;;             *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;;*;;;;;;;;!                                ~;;;;;;;;;;;             *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;;*;;;;;;;;!                                ~;;;;;;;;;;;             *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;;*;;;;;;;;!                                ~;;;;;;;;;;;             *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;;*;;;;;;;;!                                ~;;;;;;;;;;;             *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;;*;;;;;;;;!                                ~;;;;;;;;;;;             *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;;*;;;;;;;;!                                ~;;;;;;;;;;;             *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;;*;;;;;;;;!                                ~;;;;;;;;;;;             *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;;*;;;;;;;;!                                ~;;;;;;;;;;;             *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;;*;;;;;;;;*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!;;;;;;;;;;;             *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;;*;;;;!!=$===================================$*!!;;;;;;             *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;;*;;$=============================================$;;;;             *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;;;;;*=$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$==~            *;;;;;;;=---\r\n-@;;;;;;!;;;;;;;!!=***********************************************************~~.       *;;;;;;;=---\r\n-@;;;;;;!;;;!;=******************************************************************$;..   *;;;;;;;=---\r\n-@;;;;;;!:=**************************************************************************!=.*;;;;;;;=---\r\n-@;;;;*:;~------------------------------------------------------------------------------::;*;;;;=---\r\n-@!:!-~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!~!=---\r\n!,----------------------------------------------------------------------------------------------,:;-");

           Util.Print("You are in room 1.");
            Console.WriteLine("Press any key to continue...");
        }
        public override void Input()
        {
           input = Console.ReadKey(true).Key; //키 입력을 대기한다.
            //타이틀 컷신의 입력처리
        }
        public override void Update()
        {
            //타이틀 컷신의 업데이트
        }
        public override void Result()
        {
            switch(input)
            {
                case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                    Game.ChangeScene("room6");
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    // Move down
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    Game.Gameover("죽어걍");
                    // Move left
                    break;
                case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                    Game.ChangeScene("room2");
                    // Move right
                    break;
                default:
                    // Invalid input
                    break;
            }
            //타이틀 컷신의 결과처리
        }

    }
}
