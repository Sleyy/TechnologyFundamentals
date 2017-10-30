using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int skipElements = numbers[0];
            int takeElements = numbers[1];
            string pattern = @"(?:\|<)(?<name>\w+)";
            string input = Console.ReadLine();

            MatchCollection matched = Regex.Matches(input, pattern);
            List<string> output = new List<string>();
            foreach (Match m in matched)
            {
                var print = m.Groups[1].Value.Skip(skipElements).Take(takeElements);
                output.Add(string.Join("",print));
            }
            
                Console.WriteLine(string.Join(", ",output));
            
        }
    }
}
