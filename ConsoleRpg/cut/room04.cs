﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg.cut
{
    public class room04 : Basecut

    {
        private ConsoleKey input;
        public override void Render()
        {
            /*막힌길 (1)
             * 북 ,남(2)
             * 북 동 남(3)
             * 북 서 남(4)
             * 북 동 서 남(5)
             * 동 남  (6)
             * 서 남  (7)
             * 서 동 남(8)
             */
            Util.Print3D(8);
            Game.PrintInfo();
            if (Game.DeathCount >= 20)
            {
                Util.Printmap(4, 3);
            }
            Console.WriteLine();
            if (Game.DeathCount >= 5)
            {
                Util.Print("You are in room4.");
            }
            Console.WriteLine("Move Press key(→,←,↑,↓)");
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

                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    // Move down
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    {
                        Game.ChangeScene("room3");
                        Game.HpPlus();
                    }

                    // Move left
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    {
                        Game.ChangeScene("room5");
                        Game.HpPlus();
                    }
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
