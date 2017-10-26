using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            bool exchangable = BoolExchangable(input[0], input[1]);
            if (!exchangable)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }

        private static bool BoolExchangable(string s, string s1)
        {
            
            var newStr1 = s.Distinct().ToArray();
            var newStr2 = s1.Distinct().ToArray();
            if (newStr1.Length == newStr2.Length)
            {
                return true;
            }
            return false;

        }
    }
}
