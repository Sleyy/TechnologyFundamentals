using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ').ToArray();
            var secondLine = Console.ReadLine().Split(' ').ToArray();
            
            int sumOfEqualsStart = 0;
            int sumOfEqualsEnd = 0;

            for (int i = 0; i < Math.Min(firstLine.Length,secondLine.Length); i++)
            {
                if (firstLine[i] == secondLine[i])
                {
                    
                    sumOfEqualsStart++;
                }
            }
            for (int i = 1; i <= Math.Min(firstLine.Length, secondLine.Length); i++)
            {
                if (firstLine[firstLine.Length-i] == secondLine[secondLine.Length-i])
                {
                    
                    sumOfEqualsEnd++;
                }
            }

            Console.WriteLine(Math.Max(sumOfEqualsStart,sumOfEqualsEnd));

        }
    }
}
