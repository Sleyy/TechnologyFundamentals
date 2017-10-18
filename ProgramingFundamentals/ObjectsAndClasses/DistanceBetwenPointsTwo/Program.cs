using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetwenPointsTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPoint = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var secondPoint = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            Point first = new Point
            {
                X = firstPoint[0],Y = firstPoint[1]
            };
            Point second = new Point
            {
                X = secondPoint[0],
                Y = secondPoint[1]
            };
            var result = CalculateDistance(first, second);
            Console.WriteLine($"{result:f3}");
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            double sideA = firstPoint.X - secondPoint.X;
            double sideB = firstPoint.Y - secondPoint.Y;
            double distance = Math.Sqrt((sideA * sideA) + (sideB * sideB));
            return distance;
        }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
