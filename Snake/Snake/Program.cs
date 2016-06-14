﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаем размер рамки
            Console.SetBufferSize(80,25);

            // Рисуем линии рамки
            HorizontalLine UpLine = new HorizontalLine(0, 78, 0, '+');
            VerticalLine LeftLine = new VerticalLine(0, 1, 23, '+');
            VerticalLine RightLine = new VerticalLine(78, 1, 23, '+');
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '+');
            UpLine.Draw();
            DownLine.Draw();
            LeftLine.Draw();
            RightLine.Draw();

            // Случайная точка
            Point R = new Point(8, 12, '*');
            Snake snake = new Snake(R,8,Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);

            Console.ReadLine();
        }
    }
}
