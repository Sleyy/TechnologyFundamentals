using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool resulted = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;
                for (int j = i - 1; j >= 0; j--)
                {

                    leftSum += numbers[j];
                }
                for (int j = i + 1; j < numbers.Length; j++)
                {

                    rightSum += numbers[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    resulted = true;
                }

            }
            if (!resulted)
            {
                Console.WriteLine("no");
            }
        }

    }
}
