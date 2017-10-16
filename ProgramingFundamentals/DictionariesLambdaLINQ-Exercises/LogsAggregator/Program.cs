using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new SortedDictionary<string,SortedDictionary<string,int>>();

            int inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                string[] input = Console.ReadLine().Split(new string[]{" "},StringSplitOptions.RemoveEmptyEntries);

                if (!result.ContainsKey(input[1]))
                {
                    result.Add(input[1],new SortedDictionary<string, int>());
                    
                }
                if (!result[input[1]].ContainsKey(input[0]))
                {
                    result[input[1]].Add(input[0], int.Parse(input[2]));
                }
                else
                {
                    result[input[1]][input[0]]+= int.Parse(input[2]);
                }
             }
            foreach (var name in result)
            {
                
                Console.WriteLine($"{name.Key}: {name.Value.Values.Sum()} [{string.Join(", ",name.Value.Keys)}]");
                
            }
         }
    }
}
