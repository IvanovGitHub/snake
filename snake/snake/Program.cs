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
            Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            Point p2 = new Point(4, 5, '#');
           //p2.Draw();

            Point p3 = new Point(0, 0, '%');
            Point p4 = new Point(9, 3, '$');

            Console.WriteLine();

            List<int> numList = new List<int>();
            numList.Add(3);
            numList.Add(7);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            //Console.WriteLine(x + ", " + y + ", " + z);

            /*foreach (int i in numList)
            {
                Console.WriteLine(i);
            }
            */
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            pList[0].Draw();
            pList[1].Draw();
            pList[2].Draw();
            pList[3].Draw();
          
            
            Console.ReadLine();
        }
    }
}
