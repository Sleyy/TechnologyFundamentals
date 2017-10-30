using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Za-z]{1}[A-Za-z0-9_]{2,24})\b";
            string input = Console.ReadLine();

            MatchCollection matched = Regex.Matches(input, pattern);

            int sum = 0;
            int bestSum = 0;
            string firstName = String.Empty;
            string secondName = String.Empty;
            for (int i = 1; i < matched.Count; i++)
            {
                sum = matched[i].Groups[0].Value.Length + matched[i - 1].Groups[0].Value.Length;
                if (sum > bestSum)
                {
                    bestSum = sum;
                    firstName = matched[i-1].Groups[0].Value;
                    secondName = matched[i].Groups[0].Value;


                };
            }
            Console.WriteLine($"{firstName}\r\n{secondName}");
        }
    }
}
