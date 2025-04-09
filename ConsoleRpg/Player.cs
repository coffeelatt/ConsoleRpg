using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg
{
    public class Player
    {
        private int hp;
        public int Hp { get { return hp; } set { hp = value; } }

        private int attack;
        public int Attack { get { return attack; } set { attack = value; } }

        private int speed;
        public int Speed { get { return speed; } set { speed = value; } }

        private int gold;
        public int Gold { get { return gold; } set { gold = value; } }
    }
}
