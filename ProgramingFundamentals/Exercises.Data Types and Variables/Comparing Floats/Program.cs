using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numberOne = decimal.Parse(Console.ReadLine());
            decimal numberTwo = decimal.Parse(Console.ReadLine());

            decimal difference = Math.Abs(numberOne - numberTwo);

            if (difference >= 0.000001m)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
            

            
            
        }
    }
}
