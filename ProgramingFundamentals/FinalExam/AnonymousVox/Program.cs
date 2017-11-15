using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] values = Console.ReadLine()
                .Split(new string[] {"{", "}"}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string pattern = @"([A-Za-z]+)(.+)(\1+)";
            string captured = string.Empty;
            int valueCounter = 0;
            MatchCollection matches = Regex.Matches(inputLine, pattern);
            foreach (Match m in matches)
            {
                if (m.Groups[1].Value == m.Groups[3].Value)
                {
                    if (valueCounter >= values.Length)
                    {
                        break;
                    }

                    captured = m.Groups[2].Value;
                    inputLine = inputLine.Replace(captured, values[valueCounter]);

                    valueCounter++;
                }
                
            }
            Console.WriteLine(inputLine);


        }
    }
}
