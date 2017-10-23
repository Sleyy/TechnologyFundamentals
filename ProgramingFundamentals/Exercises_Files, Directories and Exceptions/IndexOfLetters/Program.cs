using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string input = File.ReadAllText("input2.txt");
            char[] inputAsChars = input.ToCharArray();
            File.Delete("result2.txt");
            foreach (var character in inputAsChars)
            {
                
                File.AppendAllText("result2.txt",character + " -> " + (character - 97)+ Environment.NewLine);
            }
        }
    }
}
