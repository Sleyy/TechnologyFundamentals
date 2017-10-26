using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            string result = String.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                result += "\\u"+((int) input[i]).ToString("x4");
            }
            Console.WriteLine(result);
        }
    }
}
