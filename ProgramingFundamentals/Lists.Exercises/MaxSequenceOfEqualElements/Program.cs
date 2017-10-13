using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int length = 1;
            int maxLength = 0;
            int lengthIndex = 1;
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i]==numbers[i+1])
                {
                    length++;
                    if (length > maxLength)
                    {
                        maxLength = length;
                        lengthIndex = numbers[i];
                    }
                }
                else
                {
                    length = 1;
                }
            }
            if (lengthIndex == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                for (int i = 0; i < maxLength; i++)
                {
                    Console.Write($"{lengthIndex} ");
                }
            }
            
        }
    }
}
