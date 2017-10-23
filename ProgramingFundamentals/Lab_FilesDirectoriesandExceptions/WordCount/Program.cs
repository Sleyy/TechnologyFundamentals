using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").ToLower().Split(new string[]{"-",","," ","?","."},StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] words = File.ReadAllText("words.txt").Split().ToArray();
            File.Delete("result.txt");
            Dictionary<string,int> result = new Dictionary<string, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (words.Contains(input[i]))
                {
                    if (!result.ContainsKey(input[i]))
                    {
                        result.Add(input[i],1);
                    }
                    else
                    {
                        result[input[i]]++;
                    }
                }
            }
            
            foreach (var item in result.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("result.txt", item.Key + "-" + item.Value+ Environment.NewLine);
            }
            
        }
    }
}
