using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOne = sbyte.Parse(Console.ReadLine());
            sbyte numberTwo = sbyte.Parse(Console.ReadLine());

            Console.WriteLine($"Before:\r\na = {numberOne}\r\nb = {numberTwo}");
            sbyte tempNumber = numberOne;
            numberOne = numberTwo;
            numberTwo = tempNumber;

            Console.WriteLine($"After:\r\na = {numberOne}\r\nb = {numberTwo}");
            
        }
    }
}
