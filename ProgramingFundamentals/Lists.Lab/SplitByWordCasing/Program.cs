using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new char[]
                {',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']',' ',' '},StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].All(Char.IsLower))
                {
                    lowerCaseWords.Add(words[i]);
                }
                else if (words[i].All(Char.IsUpper))
                {
                    upperCaseWords.Add(words[i]);
                }
                else
                {
                    mixedCaseWords.Add(words[i]);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ",lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
        }
    }
}
