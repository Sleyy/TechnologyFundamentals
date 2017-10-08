using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = new int[numbers.Length - 1];

            while (result.Length > 1)
            {
                result = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    result[i] = numbers[i] + numbers[i + 1];
                }
                numbers = new int[numbers.Length-1];
                Array.Copy(result, 0, numbers, 0, result.Length);
            }
            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                Console.WriteLine(result[0]);
            }
            
        }
    }
}
