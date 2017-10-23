using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = File.ReadAllText("input3.txt").Split(' ').Select(int.Parse).ToArray();
            File.Delete("result3.txt");
            int length = 0;
            int longestLength = 0;
            int sequence = 0;
            int start = 0;



            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[start] == numbers[i])
                {
                    length++;
                    if (length > longestLength)
                    {
                        longestLength = length;
                        sequence = start;
                    }
                }
                else
                {
                    start++;
                    i = start;
                    length = 0;

                }

            }


            for (int i = 0; i <= longestLength; i++)
            {

                File.AppendAllText("result3.txt",numbers[sequence + i] + " ");
            }
        }
    }
}
