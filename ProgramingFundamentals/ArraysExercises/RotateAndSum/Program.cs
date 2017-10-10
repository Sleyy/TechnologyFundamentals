using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var currentNumbers = new int[numbers.Length];
            int timesToRotate = int.Parse(Console.ReadLine());
            var result = new int[numbers.Length];
            for (int i = 0; i < timesToRotate; i++)
            {
                for (int g = 0; g < numbers.Length; g++)
                {
                    if (g == 0)
                    {
                        currentNumbers[g] = numbers[numbers.Length - 1 - g];
                    }
                    else
                    {
                        currentNumbers[g] = numbers[g - 1];
                    }
                }
                Array.Copy(currentNumbers, 0, numbers, 0, currentNumbers.Length);
                for (int j = 0; j < numbers.Length; j++)
                {
                    result[j] += numbers[j];
                }
            }
            Console.WriteLine(string.Join(" ",result));








        }
    }
}
