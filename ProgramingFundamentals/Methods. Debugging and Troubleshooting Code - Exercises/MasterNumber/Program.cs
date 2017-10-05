using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRange = int.Parse(Console.ReadLine());
            for (int currentNumber = 1; currentNumber <= numberRange; currentNumber++)
            {
                if (IsSymmetric(currentNumber) == true && DivisibleBySeven(currentNumber) == true && ContainsEvenDigit(currentNumber) == true)
                {
                    Console.WriteLine($"{currentNumber}");
                }
            }
        }

        static bool IsSymmetric(int numberRange)
        {
            string currentNumber = numberRange.ToString();
            for (int g = 0; g < currentNumber.Length / 2; g++)
            {
                if (currentNumber[g] == currentNumber[currentNumber.Length - 1 - g])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static bool DivisibleBySeven(int numberRange)
        {
            string number = numberRange.ToString();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += numberRange % 10;
                numberRange /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ContainsEvenDigit(int numberRange)
        {
            string number = numberRange.ToString();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum = numberRange % 10;
                if (sum % 2 == 0)
                {
                    return true
                }
                numberRange /= 10;
            }
            return false;
        }
    }
}
