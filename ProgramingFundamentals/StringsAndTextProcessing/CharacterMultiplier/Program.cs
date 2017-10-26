using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string firstWord = input[0];
            string secondWord = input[1];

            Console.WriteLine(MultiplyCharacters(input[0], input[1]));
            
        }

        private static int MultiplyCharacters(string s, string s1)
        {
            int sum = 0;
            for (int i = 0; i < Math.Min(s.Length,s1.Length); i++)
            {
                sum += s[i] * s1[i];
            }
            if (s.Length > s1.Length)
            {
                for (int i = 0; i < s.Length-s1.Length; i++)
                {
                    sum += s[s.Length - i - 1];
                }
            }
            else if (s1.Length > s.Length)
            {
                for (int i = 0; i < s1.Length - s.Length; i++)
                {
                    sum += s1[s1.Length - i - 1];
                }
            }
            return sum;
        }
    }
}
