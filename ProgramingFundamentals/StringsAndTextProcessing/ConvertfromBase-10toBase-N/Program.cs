using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertfromBase_10toBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse).ToArray();

            BigInteger power = input[0];
            BigInteger number = input[1];
            string binary = String.Empty;
            while (number>0)
            {
                binary = number % power + binary;
                number /= power;
            }
            
            Console.WriteLine(binary);
        }
    }
}
