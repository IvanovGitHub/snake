using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine line1 = new HorizontalLine(0, 10, 0, '#');
            line1.Draw();

            HorizontalLine line2 = new HorizontalLine(0, 10, 10, '#');
            line2.Draw();

            VerticalLine line3 = new VerticalLine(0, 9, 0, '#');
            line3.Draw();

            VerticalLine line4 = new VerticalLine(0, 9, 10, '#');
            line4.Draw();

            Console.ReadLine();
        }
    }
}
