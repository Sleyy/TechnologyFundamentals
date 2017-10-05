using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureName = Console.ReadLine();
            GetFigureArea(figureName);
        }

        static void GetFigureArea(string figureName)
        {
            double result = 0;
            if (figureName == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                result = squareSide * squareSide;
            }
            else if (figureName == "circle")
            {
                double circleRadius = double.Parse(Console.ReadLine());
                result = Math.PI * (Math.Pow(circleRadius, 2));
            }
            else if (figureName == "triangle")
            {
                double sideOfTriangle = double.Parse(Console.ReadLine());
                double heightOfTriangle = double.Parse(Console.ReadLine());
                result = (heightOfTriangle * sideOfTriangle)/ 2;
            }
            else if(figureName == "rectangle")
            {
                double rectangleWidth = double.Parse(Console.ReadLine());
                double rectangleHeight = double.Parse(Console.ReadLine());
                result = rectangleWidth * rectangleHeight;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
