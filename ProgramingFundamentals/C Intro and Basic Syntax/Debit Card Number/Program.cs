using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOne = int.Parse(Console.ReadLine());
            var numTwo = int.Parse(Console.ReadLine());
            var numThree = int.Parse(Console.ReadLine());
            var numFour = int.Parse(Console.ReadLine());

            Console.WriteLine($"{numOne:D4} {numTwo:D4} {numThree:D4} {numFour:D4}");
        }
    }
}
