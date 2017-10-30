using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            string text = Console.ReadLine();

            var matchedText = Regex.Matches(text, pattern).Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray(); ;

            
            Console.WriteLine(string.Join(" ",matchedText));
        }
    }
}
