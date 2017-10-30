using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string text = Console.ReadLine();

            MatchCollection result = Regex.Matches(text, regex);
            foreach (Match m in result)
            {
                Console.Write($"{m.Value} ");
            }
        }
    }
}
