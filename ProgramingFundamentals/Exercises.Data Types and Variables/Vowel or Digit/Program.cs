using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbol = Console.ReadLine().ToLower();
            int number;

            if (int.TryParse(symbol,out number ))
            {
                Console.WriteLine("digit");
            }
            else if (symbol == "a" || symbol == "o" || symbol == "e" || symbol == "i" || symbol == "u")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }

        }
    }
}
