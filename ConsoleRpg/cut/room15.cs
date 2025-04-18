﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg.cut
{
    public class room15 : Basecut

    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("You are in room 2.");
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
            switch (input)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    Game.ChangeScene("room12");
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    // Move down
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:

                    // Move left
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:

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
