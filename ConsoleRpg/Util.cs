using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
