using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            bool hasResult = false;
            for (long i = 0; i < numbers.Length; i++)
            {
                for (long j = 0; j < numbers.Length; j++)
                {
                    for (long k = 0; k < numbers.Length; k++)
                    {
                        if (0 <= i && i < j &&  numbers[i] + numbers[j] == numbers[k])
                        {
                            hasResult = true;
                            Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[k]}");
                            break;
                        }
                    }
                }
            }
            if (!hasResult)
            {
                Console.WriteLine("No");
            }
        }
    }
}
