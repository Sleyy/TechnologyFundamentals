using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = 0;
            int longestLength = 0;
            int sequence = 0;
            int start = 0;



            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[start] < numbers[i] )
                {
                    length++;

                    if (length > longestLength)
                    {
                        longestLength = length;
                        sequence = i;

                    }
                }
                else
                {


                    length = 0;
                }
                start++;
                i = start;
            }


            for (int i = 0; i <= longestLength; i++)
            {

                Console.Write(numbers[sequence-longestLength  + i] + " ");
            }
        }
    }
}
