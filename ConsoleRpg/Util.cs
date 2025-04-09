using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg
{
    public static class Util
    {
        public static void Clear()
        {
            Console.Clear();
        }
        public static void WaitForKeyPress()
        {
            Console.ReadKey(true);
        }
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void Print(string context, ConsoleColor textColor = ConsoleColor.White)
        {
            Console.ForegroundColor = textColor;

            foreach (char i in context)
            {
                Console.Write(i);
                Thread.Sleep(30);
            }
            Console.ResetColor();
            Console.WriteLine("");
        }
            public static void Print2(string context, ConsoleColor textColor = ConsoleColor.White, int delay = 0)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(context);
            Thread.Sleep(delay);
            Console.ResetColor();
        }

        
        public static void Printmap(int x ,int y)
        {
            Console.SetCursorPosition(20, 20);
            char[,] map = new char[,]
            {
                {'□','□','□','□','□' },
                {'□','□','□','□','□' },
                {'□','□','□','□','□' },
                {'□','□','□','□','□' },
                {'□','□','□','□','□' }
            };
            for(int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (i == x && j == y)
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write(map[i, j]);
                    }
                }
                Console.WriteLine("\n");
            }



        }


    }
}
