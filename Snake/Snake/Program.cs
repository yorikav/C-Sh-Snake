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
            Point p1 = new Point(1, 3,  '*');
            p1.Draw();
            
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine Hline = new HorizontalLine(3, 9, 12, '+');
            Hline.Draw();

            VerticalLine Vline = new VerticalLine(11, 15, 19, '@');
            Vline.Draw();

            Console.ReadLine();
        }
    }
}
