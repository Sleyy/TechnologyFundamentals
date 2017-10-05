using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            ClosestToCenter(x1, y1, x2, y2);
            
        }

        static void ClosestToCenter(double x1 , double y1 , double x2 , double y2)
        {
            
            double distanceOfPointOne = Math.Sqrt((x1 * x1) + (y1 * y1));
            double distanceOfPointTwo = Math.Sqrt((x2 * x2) + (y2 * y2));
            distanceOfPointOne = Math.Abs(distanceOfPointOne);
            distanceOfPointTwo = Math.Abs(distanceOfPointTwo);

            if (distanceOfPointOne < distanceOfPointTwo)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (distanceOfPointOne > distanceOfPointTwo)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if (distanceOfPointOne == distanceOfPointTwo)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
