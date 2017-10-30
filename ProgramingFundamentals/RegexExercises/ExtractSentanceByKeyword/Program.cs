using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentanceByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string pattern = $@"[^.?!;]*(\b{keyword}\b)[^.?!;]*";
            string input = Console.ReadLine();

            MatchCollection matched = Regex.Matches(input, pattern);

            foreach (Match m in matched)
            {
                Console.WriteLine(m.Value.TrimStart().TrimEnd());
            }

        }
    }
}
