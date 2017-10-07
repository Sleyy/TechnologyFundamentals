using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcFactorialTrailingZeroes(number));
        }

        static BigInteger CalcFactorialTrailingZeroes(int number)
        {
            BigInteger factorial = 1;
            int numberOfTrailingZeroes = 0;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            string factorialAsText = factorial.ToString();

            for (int i = factorialAsText.Length; i >= 1; i--)
            {
                if (factorialAsText.EndsWith("0"))
                {
                    factorialAsText = factorialAsText.Remove(factorialAsText.Length - 1);
                    numberOfTrailingZeroes++;
                    continue;
                }
                else
                {
                    break;
                }
            }
            return numberOfTrailingZeroes;
        }
    }
}
