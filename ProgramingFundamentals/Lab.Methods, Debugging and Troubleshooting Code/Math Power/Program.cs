using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double powerOfNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(PrintPoweredNumber(number, powerOfNumber)); 
            
        }

        static double PrintPoweredNumber(double number, double powerOfNumber)
        {
            double result = 1.0;
            for (int i = 1; i <= powerOfNumber; i++)
            {
                result = result * number;
            }
            return result;
            
        }
    }
}
