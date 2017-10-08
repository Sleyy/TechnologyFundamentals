using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] sequence = new long[n];

            sequence[0] = 1;

            long sum = 1;

            for (int i = 1; i <= sequence.Length ; i++)
            {
                for (int j = i - k; j < i - 1; j++)
                {
                    if (j > 0)
                    {
                        sum += sequence[j - 1];
                    }

                }
                sequence[i - 1] = sum;

            }
            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write($"{sequence[i]} ");
            }

        }
    }
}


