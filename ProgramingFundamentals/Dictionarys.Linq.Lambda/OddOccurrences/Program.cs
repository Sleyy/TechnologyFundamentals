using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToArray();
            Dictionary<string,int> result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (result.ContainsKey(word))
                {
                    result[word]++;
                }
                else
                {
                    result[word] = 1;
                }
            }
            List<string> finalResult = new List<string>();
            foreach (var item in result)
            {
                if (item.Value % 2 != 0 )
                {
                   finalResult.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ",finalResult));
        }
    }
}
