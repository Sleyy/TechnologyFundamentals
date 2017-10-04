using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_By_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintEvenByOdds(number));
        }

        static int PrintEvenByOdds(int number)
        {
            number = Math.Abs(number);
            int result = 0;
            int oddNumbers = 0;
            int evenNumbers = 0;
            int lastDigit = 0;

            while (number > 0)
            {
                lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    oddNumbers += lastDigit;
                }
                else
                {
                    evenNumbers += lastDigit;
                }
                number /= 10;
            }
            result = oddNumbers * evenNumbers;
            return result;
        }
    }
}
