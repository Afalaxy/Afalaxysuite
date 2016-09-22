using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(1, 3, '*');
            p1.Draw();

            point p2 = new point(4, 5, '#');
            p2.Draw();

            point p3 = new point(2, 4, '0');
            p3.Draw();

            point p4 = new point(3, 8, 'r');
            p3.Draw();

            List<point> pList = new List<point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            


        
            Console.ReadLine();

        }
    }
}

