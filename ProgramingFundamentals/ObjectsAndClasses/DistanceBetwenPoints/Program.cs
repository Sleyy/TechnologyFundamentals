using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetwenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pointOne = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] pointTwo = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var pointInfo = new Point();
            double distance = pointInfo.CalcDistance(pointOne, pointTwo);
            Console.WriteLine($"{distance:f3}");
        }
    }

    public class Point
    {
        public double CalcDistance(int[] pointOne,int[] pointTwo)
        {
            int sideA = Math.Abs(pointOne[0] - pointTwo[0]);
            int sideB = Math.Abs(pointOne[1] - pointTwo[1]);
            double distance = Math.Sqrt((sideA * sideA) + (sideB * sideB));
            return distance;
        }
    }

}
