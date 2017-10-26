using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new string[] {" ", ",", ".", "?", "!"}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> palindromeWords = new List<string>();
            foreach (var word in input)
            {
                bool isPalindrome = true;
                for (int i = 0; i < word.Length/2; i++)
                {
                    if (word[i] == word[word.Length-1-i])
                    {
                        continue;;
                    }
                    else
                    {
                        isPalindrome = false;
                    }
                }
                if (isPalindrome)
                {
                    if (!palindromeWords.Contains(word))
                    {
                        palindromeWords.Add(word);
                    }
                   
                }
                
            }
            
                Console.WriteLine(string.Join(", ",palindromeWords.OrderBy(x=>x)));
            
        }
    }
}
