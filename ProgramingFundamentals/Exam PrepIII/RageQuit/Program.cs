using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([^0-9]+)([0-9]+)";
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            MatchCollection matched = Regex.Matches(input, pattern);

            foreach (Match m in matched)
            {
                for (int i = 0; i < int.Parse(m.Groups[2].Value); i++)
                {
                    result.Append(m.Groups[1].Value.ToUpper());
                }
            }
            char[] numberOfSymbols = result.ToString().ToCharArray().Distinct().ToArray();
            Console.WriteLine($"Unique symbols used: {numberOfSymbols.Length}");
            Console.WriteLine(result);
        }
    }
}
