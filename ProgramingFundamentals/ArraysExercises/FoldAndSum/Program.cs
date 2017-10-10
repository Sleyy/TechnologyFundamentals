using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var firstRow = new int[numbers.Length / 2];
            var secondRow = new int[numbers.Length / 2];
            var result = new int[numbers.Length / 2];

            for (int i = 0; i < firstRow.Length/2; i++)
            {
                firstRow[i] = numbers[(numbers.Length / 4) - 1 - i];
                firstRow[firstRow.Length/2+i] = numbers[numbers.Length - 1 - i];
            }
            for (int i = 0; i < secondRow.Length ; i++)
            {
                secondRow[i] = numbers[(numbers.Length / 4) + i];
               
            }
            for (int i = 0; i < numbers.Length/2; i++)
            {
                result[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ",result));


        }
    }
}
