using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg
{
    public class Monster
    {
        public string name;
        public int speed;
        public int hp;
        public int attack;

        public Monster(string name, int speed, int hp,int attack)
        {
            this.name = name;
            this.speed = speed;
            this.hp = hp;
            this.attack = attack; // 기본 공격력 설정
        }

        
    }

    public class MonsterFactory
    {
        public float rate;
        public Monster Create(string name)
        {
            Monster monster;
            switch (name)
            {
                case "슬라임": monster = new Monster("슬라임", 1, 100,5); break;
                case "고블린": monster = new Monster("고블린", 1, 200,7); break;
                case "슬라임왕": monster = new Monster("슬라임왕", 3, 500,10); break;
                default: return null;
            }
            
            return monster;

        }

    }

}
