using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int count = 0;
            int mostCount = 0;
            int mostFrequentNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i]==numbers[j])
                    {
                        count++;
                        if (count>mostCount)
                        {
                            mostCount = count;
                            mostFrequentNumber = numbers[i];
                        }
                    }
                }
                count = 0;
            }
            Console.WriteLine(mostFrequentNumber);
        }
    }
}
