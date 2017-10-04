using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte key = sbyte.Parse(Console.ReadLine());
            sbyte numberOfChars = sbyte.Parse(Console.ReadLine());
            string fullLetter = "";
            for (int i = 0; i < numberOfChars; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                fullLetter += Convert.ToChar(letter+key);
            }
            Console.WriteLine(fullLetter);
        }
    }
}
