using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPoints = int.Parse(Console.ReadLine());
            var points = new List<Point>();

            for (int i = 0; i < numberOfPoints; i++)
            {
                double[] currentPoint = Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray(); 
                points.Add(new Point
                {
                    X = currentPoint[0],
                    Y = currentPoint[1]
                });
            }
            double maxDistance = double.MaxValue;
            Point firstBest = null;
            Point secondBest = null;
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i+1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];
                    var currentDistance = CalculateDistance(firstPoint, secondPoint);
                    if (currentDistance < maxDistance)
                    {
                        maxDistance = currentDistance;
                        firstBest = firstPoint;
                        secondBest = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{maxDistance:f3}");
            Console.WriteLine($"({firstBest.X}, {firstBest.Y})");
            Console.WriteLine($"({secondBest.X}, {secondBest.Y})");
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
