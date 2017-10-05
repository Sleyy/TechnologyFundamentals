using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           
            Console.WriteLine(GetFibNumber(number));
        }

        static int GetFibNumber(int number)
        {
            int fibNumber = 0;
            int firstNumber = 0;
            int secondNumber = 1;
            if (number == 0)
            {
                fibNumber = 1;
            }

            else
            {
                for (int i = 0; i < number; i++)
                {
                    fibNumber = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = fibNumber;


                }
            }
           
            return fibNumber ;
        }
    }
}
