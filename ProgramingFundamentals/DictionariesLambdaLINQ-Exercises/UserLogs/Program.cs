using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> result = new SortedDictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                string[] splitInput = input.Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
                string iP = splitInput[1];
                string user = splitInput[5];
                int counter = 1;


                if (!result.ContainsKey(user))
                {
                    
                    result.Add(user, new Dictionary<string, int>());
                }
                if (!result[user].ContainsKey(iP))
                {
                    result[user].Add(iP, counter);
                }
                else
                {

                    result[user][iP]++;
                }
                input = Console.ReadLine();
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var element in item.Value)
                {
                    if (element.Key != item.Value.Keys.Last())
                    {
                        Console.Write($"{element.Key} => {element.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{element.Key} => {element.Value}.");
                    }
                }
            }
        }
    }
}

