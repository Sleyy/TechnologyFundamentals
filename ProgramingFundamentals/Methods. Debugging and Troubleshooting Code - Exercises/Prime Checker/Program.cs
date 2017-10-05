using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number)); 
        }

        static bool IsPrime(long number)
        {
            bool prime = true;
            int sqrtNumber = (int)Math.Sqrt(number);
            if (number > 1)
            {
                for (int i = 2; i <= sqrtNumber ; i++)
                {
                    if (number % i == 0 && i != number)
                    {
                        prime = false;
                    }
                   
                }
            }
            else
            {
                prime = false;
            }
            return prime;
        }
    }
}
