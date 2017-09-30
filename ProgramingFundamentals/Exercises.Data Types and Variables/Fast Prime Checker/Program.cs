using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte number = sbyte.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                bool prime = true;
                for (int g = 2; g <= i/2; g++)
                {
                    if (i % g == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {prime}");
            }

        }
    }
}
