using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string uglyPattern =
                @"\s+\b([a-z0-9]|[a-z0-9]+)(.|-|_)([a-z0-9]|[a-z0-9]+)\@[a-z]+(-?)[a-z]+\.[a-z]+\.?[a-z]+\b";
            string input = Console.ReadLine();

            MatchCollection matched = Regex.Matches(input, uglyPattern);

            foreach (Match m in matched)
            {
                Console.WriteLine(m.Value.TrimStart());
            }
        }
    }
}
