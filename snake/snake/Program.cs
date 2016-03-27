using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine line1 = new HorizontalLine(0, 78, 0, '#');
            line1.Draw();

            HorizontalLine line2 = new HorizontalLine(0, 78, 24, '#');
            line2.Draw();

            VerticalLine line3 = new VerticalLine(0, 24, 0, '#');
            line3.Draw();

            VerticalLine line4 = new VerticalLine(0, 24, 78, '#');
            line4.Draw();

            Point p = new Point(4, 5, 'O');
            snake snake = new snake(p, 10, Direction.Rigth);
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

         
            Console.ReadLine();
        }
    }
}
