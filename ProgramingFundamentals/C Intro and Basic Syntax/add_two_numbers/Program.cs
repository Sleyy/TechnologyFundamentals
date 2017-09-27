using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOne = double.Parse(Console.ReadLine());
            var numberTwo = double.Parse(Console.ReadLine());

            var sum = numberOne + numberTwo;

            Console.WriteLine($"{numberOne} + {numberTwo} = {sum}");
        }
    }
}
