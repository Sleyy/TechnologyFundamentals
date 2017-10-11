using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            
            while (true)
            {
                bool hasEquals = false;
                for (int i = 0; i < numbers.Count-1; i++)
                {
                    if (numbers[i]==numbers[i+1])
                    {
                        hasEquals = true;
                        numbers[i] += numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                    }
                }
                if (!hasEquals)
                {
                    Console.WriteLine(string.Join(" ",numbers));
                    break;
                }
            }
        }
    }
}
