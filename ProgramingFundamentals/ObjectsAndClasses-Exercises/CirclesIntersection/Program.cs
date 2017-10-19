using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CirclesIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputFirstPoint = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] inputSecondPoint = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Circle c1 = new Circle();
            c1.Radius = inputFirstPoint[2];
            Point c1Center = new Point();
            c1Center.X = inputFirstPoint[0];
            c1Center.Y = inputFirstPoint[1];

            Circle c2 = new Circle();
            c2.Radius = inputSecondPoint[2];
            Point c2Center = new Point();
            c2Center.X = inputSecondPoint[0];
            c2Center.Y = inputSecondPoint[1];

            double distance = CalcDistance(c1Center, c2Center);
            if (Intersect(c1,c2,distance))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static double CalcDistance(Point c1Center, Point c2Center)
        {
            double distance = Math.Sqrt(Math.Pow((c1Center.X - c2Center.X),2) + Math.Pow((c1Center.Y - c2Center.Y), 2));
            return distance;
        }

        static bool Intersect(Circle c1, Circle c2, double distance)
        {
            if (distance <= c1.Radius+c2.Radius)
            {
                return true;
            }
           
                return false;
            

       
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class Circle
    {
        public int Center { get; set; }
        public int Radius { get; set; }
    }

}
