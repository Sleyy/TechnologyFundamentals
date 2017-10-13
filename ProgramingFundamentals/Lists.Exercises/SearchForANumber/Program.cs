using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] integers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            List<int> finalNumbers = new List<int>();

            for (int i = 0; i < integers[0]; i++)
            {
                finalNumbers.Add(numbers[i]);
            }
            for (int i = 0; i < integers[1]; i++)
            {
                finalNumbers.RemoveAt(0);
            }
            if (finalNumbers.Contains(integers[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
            
        }
    }
}
