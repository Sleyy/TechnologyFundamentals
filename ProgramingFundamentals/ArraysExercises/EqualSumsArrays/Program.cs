using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            
            bool resulted = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSum = numbers.Take(i).ToArray();
                int[] rightSum = numbers.Skip(i + 1).ToArray();

                if (leftSum.Sum() == rightSum.Sum())
                {
                    Console.WriteLine(i);
                    resulted = true;
                    break;
                    
                }

            }
            if (!resulted)
            {
                Console.WriteLine("no");
            }
        }

    }
}
