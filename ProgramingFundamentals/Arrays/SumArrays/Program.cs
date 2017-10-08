using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = new int[Math.Max(firstIntegers.Length, secondIntegers.Length)];

            for (int i = 0; i < Math.Max(firstIntegers.Length, secondIntegers.Length); i++)
            {
                result[i] = firstIntegers[i % firstIntegers.Length] + secondIntegers[i % secondIntegers.Length];
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
