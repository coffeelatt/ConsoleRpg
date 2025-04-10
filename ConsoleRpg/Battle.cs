using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg
{
    public  class Battle : Game
    {//배틀씬의 구현
        public static void StartBattle()
        {
            Console.WriteLine("Battle started!");
            // 배틀 로직을 여기에 구현
            // 예: 적 생성, 턴 기반 전투 등
            


        }
        public static void EndBattle()
        {
            Console.WriteLine("Battle ended!");
            // 배틀 종료 후 처리
        }


    }
}
