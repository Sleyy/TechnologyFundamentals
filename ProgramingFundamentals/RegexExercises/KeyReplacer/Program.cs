using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyPattern = @"([A-Za-z]+)[<|\\||].*[<|\\||]([A-Za-z]+)";
            string inputKey = Console.ReadLine();
            string inputText = Console.ReadLine();

            MatchCollection matchedKeys = Regex.Matches(inputKey, keyPattern);
            string startKey = matchedKeys[0].Groups[1].ToString();
            string endKey = matchedKeys[0].Groups[2].ToString();
            string inputPattern = $@"{startKey}(\w*?){endKey}";

            string result = string.Empty;

            MatchCollection matchedText = Regex.Matches(inputText, inputPattern);


            foreach (Match m in matchedText)
            {
                result += m.Groups[1].Value;
            }

            if (result != string.Empty)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
