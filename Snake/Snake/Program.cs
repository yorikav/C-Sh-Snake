﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            Console.SetCursorPosition(x1, y1);
            Console.WriteLine(sym1);

            int x2 = 3;
            int y2 = 5;
            char sym2 = '#';

            Console.SetCursorPosition(x2, y2);
            Console.WriteLine(sym2);

            Console.ReadLine();
        }
    }
}
