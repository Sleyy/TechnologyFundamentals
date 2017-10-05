using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            string numbers = String.Join(", ", FindPrimesInRange(startNum, endNum).ToArray());
            Console.WriteLine(numbers);
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> numbers = new List<int>();
            
            for (int i = startNum; i <= endNum; i++)
            {
                bool prime = true;
                for (int g = 2; g <= i; g++)
                {
                    if (i % g == 0 && g != i)
                    {
                        prime = false;
                    }
                }
                if (prime == true)
                {
                    numbers.Add(i);
                }
            }
            return numbers;
            
        }
    }
}
