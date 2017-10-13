using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> Lis = new List<int>();
            int[] len = new int[numbers.Count - 1];
            int[] prev = new int[numbers.Count - 1];

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int left = i - 1;
                if (left < 0)
                {
                    len[i] = 1;
                }
                else
                {
                    len[i] = 1 + len[left];
                }
                prev[i] = left;


            }
        }
    }
}
