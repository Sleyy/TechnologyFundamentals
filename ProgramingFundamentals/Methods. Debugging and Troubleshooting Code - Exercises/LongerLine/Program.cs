using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            GetPointsOfLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void GetPointsOfLongerLine(double x1 , double y1 , double x2 , double y2 , double x3 , double y3 , double x4 , double y4)
        {
            double distanceOfFirstLine = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            double distanceOfSecondLine = Math.Sqrt(((x4 - x3) * (x4 - x3)) + ((y4 - y3) * (y4 - y3)));

            if (distanceOfFirstLine >= distanceOfSecondLine)
            {
                double distanceOfPointOne = Math.Sqrt((x1 * x1) + (y1 * y1));
                double distanceOfPointTwo = Math.Sqrt((x2 * x2) + (y2 * y2));
                
                if (distanceOfPointOne <= distanceOfPointTwo)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else if (distanceOfPointOne > distanceOfPointTwo)
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else if (distanceOfFirstLine < distanceOfSecondLine)
            {
                double distanceOfPointThree = Math.Sqrt((x3 * x3) + (y3 * y3));
                double distanceOfPointFour = Math.Sqrt((x4 * x4) + (y4* y4));
                
                if (distanceOfPointThree <= distanceOfPointFour)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else if (distanceOfPointThree > distanceOfPointFour)
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
            


        }
    }
}
