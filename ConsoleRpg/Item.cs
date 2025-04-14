using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg
{
    public class Item       //시간 부족 구현못함
                            // 클래스 사용없이 직통으로 함..
    {
        public string name;
        public int attack;
        public int hp;
        public int speed;

        public Item(string name, int attack, int hp, int speed)
        {
            this.name = name;
            this.attack = attack;
            this.hp = hp;
            this.speed = speed;
        }


    }
    public class  ItemMaker
    {
       // public static Item CreateItem(string name, int attack, int hp, int speed)
        //{
           // return new Item(attack, hp, speed);
        //}

    }
}
