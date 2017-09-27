using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            if (word.EndsWith("y"))
            {
                word = word.Replace("y", "ies");
                Console.WriteLine(word);
            }
            else if (word.EndsWith("o"))
            {
                word.Replace("0", "es");
                Console.WriteLine(word);
            }
            else if (word.EndsWith("ch"))
            {
                word.Replace("ch", "es");
                Console.WriteLine(word);
            }
            else if (word.EndsWith("s"))
            {
                word.Replace("s", "es");
                Console.WriteLine(word);
            }
            else if (word.EndsWith("sh"))
            {
                word.Replace("sh", "es");
                Console.WriteLine(word);
            }
            else if (word.EndsWith("x"))
            {
                word.Replace("x", "es");
                Console.WriteLine(word);
            }
            else if (word.EndsWith("z"))
            {
                word.Replace("z", "es");
                Console.WriteLine(word);
            }
            else
            {
                Console.WriteLine($"{word}s");
            }
        }
    }
}