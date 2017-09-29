using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool special = false;
            for (int i = 1; i <= number; i++)
            {
                int firstDigit = i % 10;
                int secondDigit = i / 10;
                int thirdDigit = i / 100;

                if (firstDigit + secondDigit + thirdDigit == 5 || firstDigit + secondDigit + thirdDigit == 7 || firstDigit + secondDigit + thirdDigit == 11)
                {
                    special = true;
                }
                else
                {
                    special = false;
                }
                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}
