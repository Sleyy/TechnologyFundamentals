using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            bool special = false;

            for (int i = 1; i <= number; i++)
            {
                sum = i % 10 +i / 10 + i / 100;
                
                if (sum == 5 || sum == 7 || sum == 11)
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
