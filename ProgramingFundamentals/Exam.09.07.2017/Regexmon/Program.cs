using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string bojoPattern = @"([A-Za-z]+-[A-Za-z]+)";
            string didiPattern = @"[^A-Za-z-]+";
            string input = Console.ReadLine();
            int turnCounter = 0;
            while (input.Length > 0)
            {
                if (turnCounter % 2 == 0)
                {
                    MatchCollection matched = Regex.Matches(input, didiPattern);
                    if (matched.Count == 0)
                    {
                        break;
                    }
                    string output = matched[0].Groups[0].Value;
                    Console.WriteLine(output);
                    input = input.Remove(0, input.IndexOf(output)+output.Length);
                    
                }
                else
                {
                    MatchCollection matched = Regex.Matches(input, bojoPattern);
                    if (matched.Count == 0)
                    {
                        break;
                    }
                    string output = matched[0].Groups[0].Value;
                    Console.WriteLine(output);
                    input = input.Remove(0, input.IndexOf(output) + output.Length);
                }
                turnCounter++;
            }

        }
    }
}
