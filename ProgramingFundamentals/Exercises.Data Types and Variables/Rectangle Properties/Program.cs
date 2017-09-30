using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double rectangleWidth = double.Parse(Console.ReadLine());
            double rectangleHeight = double.Parse(Console.ReadLine());

            double perimeter = (rectangleHeight + rectangleWidth) * 2;
            double area = rectangleWidth * rectangleHeight;
            double diagonal = Math.Sqrt((rectangleHeight*rectangleHeight)+(rectangleWidth*rectangleWidth));

            Console.WriteLine($"{perimeter}\r\n{area}\r\n{diagonal}");
        }
    }
}
