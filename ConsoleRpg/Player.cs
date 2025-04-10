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
        public int Hp { get; set; }
        private float attack;
        public float Attack { get; set; }
        private float speed;
        public float Speed { get; set; }
        private int gold = 0;
        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }
    }
}
