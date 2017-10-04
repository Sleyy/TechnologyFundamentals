using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            ConvertFahrenheitToCelsius(fahrenheit);
        }

        static void ConvertFahrenheitToCelsius(double fahrenheit)
        {
            Console.WriteLine($"{((fahrenheit - 32) * 5 / 9):f2}");
        }
    }
}
