using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_A_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfChars = sbyte.Parse(Console.ReadLine());
            string word = " ";
            for (int i = 0; i < numberOfChars; i++)
            {
                string character = Console.ReadLine();

                word += character;
            }
            Console.WriteLine($"The word is:{word}");
        }
    }
}
