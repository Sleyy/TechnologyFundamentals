using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                List<char> reversedNumbers = new List<char>(numbers[i]);
                reversedNumbers.Reverse();
                numbers[i] = string.Join("", reversedNumbers);
                sum += int.Parse(numbers[i]);
            }
            Console.WriteLine(sum);
            

            
        }
    }
}
