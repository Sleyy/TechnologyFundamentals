using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine();
            sbyte numberOfStrings = sbyte.Parse(Console.ReadLine());
            string sentance = "";
            for (int i = 1; i <= numberOfStrings; i++)
            {
                string word = Console.ReadLine();
                if (evenOrOdd == "even")
                {
                    if (i % 2 == 0)
                    {
                        sentance += word + delimiter;

                    }
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        sentance += word + delimiter;

                    }
                }
            }
            Console.WriteLine($"{sentance.Remove(sentance.Length-1)}");
        }
    }
}
