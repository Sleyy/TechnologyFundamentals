using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = File.ReadAllText("input5.txt")
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            File.Delete("result5.txt");
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
                    File.AppendAllText("result5.txt", i.ToString());
                    resulted = true;
                }

            }
            if (!resulted)
            {
                File.AppendAllText("result5.txt","no");
            }
        }
    }
}
