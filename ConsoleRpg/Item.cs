using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg
{
    public class Item
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
