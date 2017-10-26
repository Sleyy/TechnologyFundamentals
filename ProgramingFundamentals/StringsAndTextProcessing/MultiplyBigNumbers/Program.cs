using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart('0');
            string secondNumber = Console.ReadLine().TrimStart('0');
            string first = String.Empty;
            string second = String.Empty;
            if (firstNumber.Length < secondNumber.Length)
            {
                first = firstNumber;
                second = secondNumber;
            }
            else if (secondNumber.Length < firstNumber.Length)
            {
                first = secondNumber;
                second = firstNumber;
            }
            else
            {
                first = firstNumber;
                second = secondNumber;
            }




            int remainder = 0;
            int sum = 0;
            int number = 0;
            StringBuilder result = new StringBuilder();


            for (int i = Math.Min(first.Length - 1, second.Length - 1); i >= 0; i--)
            {

                for (int j = Math.Max(first.Length - 1, second.Length - 1); j >= 0; j--)
                {
                    sum = ((first[i] - 48) * (second[j] - 48)) + remainder;
                    number = sum % 10;
                    result.Append(number);

                    remainder = sum / 10;



                }
                if (i == 0 && remainder > 0)
                {
                    result.Append(remainder);
                }

            }
            if (first == "")
            {
                Console.WriteLine($"0");
            }
            else
            {
                Console.WriteLine(new string(result.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));
            }
        }
    }
}
