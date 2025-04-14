using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg
{
    public  class Battle 
    {//배틀씬의 구현

        public static Game game = new Game();
        public static MonsterFactory monsterFactory = new MonsterFactory();

        

        public static void StartBattle()
        {
            Console.Clear();
            
            Game.PrintInfo();
            Random random = new Random();
            int monsterIndex = random.Next(0, 3); // 0~2까지의 랜덤한 정수 생성
            int reward = random.Next(1, 100); // 1~99까지의 랜덤한 정수 생성
            // 몬스터 팩토리에서 몬스터 생성
            string name;
            if (monsterIndex == 0)
            {
                name = "슬라임";
            }
            else if (monsterIndex == 1)
            {
               name = "고블린";
            }
            else
            {
                name = "슬라임왕";
            }
            Monster monster = monsterFactory.Create(name);
            MonsterInfo(monster,reward);
            ConsoleKey input = Console.ReadKey(true).Key;


        }
        public static void EndBattle()
        {
            Console.WriteLine("Battle ended!");
            // 배틀 종료 후 처리
        }

        public static void MonsterInfo(Monster monster , int reward)
        {
            Console.WriteLine("┌─────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│  {0}                                                   │",monster.name);
            Console.WriteLine("│                                                             │");
            Console.WriteLine("│    HP : {0}\tSpeed : {1}\tAttack : {2}\t Gold : {3}   │", monster.hp, monster.speed, monster.attack, reward);
            Console.WriteLine("└─────────────────────────────────────────────────────────────┘");
            Console.WriteLine();
        }



    }
}
