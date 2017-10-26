using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string keyWord = Console.ReadLine().ToLower();
            int counter = 0;
            int index = text.IndexOf(keyWord);

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(keyWord, index + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
