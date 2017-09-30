using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOne = sbyte.Parse(Console.ReadLine());
            byte numberTwo = byte.Parse(Console.ReadLine());
            short numberThree = short.Parse(Console.ReadLine());
            ushort numberFour = ushort.Parse(Console.ReadLine());
            uint numberFive = uint.Parse(Console.ReadLine());
            int numberSix = int.Parse(Console.ReadLine());
            long numberSeven = long.Parse(Console.ReadLine());


            Console.WriteLine(numberOne);
            Console.WriteLine(numberTwo);
            Console.WriteLine(numberThree);
            Console.WriteLine(numberFour);
            Console.WriteLine(numberFive);
            Console.WriteLine(numberSix);
            Console.WriteLine(numberSeven);
        }
    }
}
