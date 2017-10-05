using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            GetParameter(sideOfCube, parameter);
            
        }

        static void GetParameter(double sideofCube, string parameter)
        {
            double result = 0;
            if (parameter == "face")
            {
                result = Math.Sqrt(2 * (Math.Pow(sideofCube, 2)));
            }
            else if (parameter == "space")
            {
                result = Math.Sqrt(3 * (Math.Pow(sideofCube, 2)));
            }
            else if (parameter == "volume")
            {
                result = Math.Pow(sideofCube, 3);
            }
            else if (parameter == "area")
            {
                result = 6 * (Math.Pow(sideofCube, 2));
            }
            Console.WriteLine($"{result:f2}");

        }
    }
}
