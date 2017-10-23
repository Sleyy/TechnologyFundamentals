using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineCounter = 0;
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string materials = "";
            int quantity = 0;
            var input = File.ReadAllText("input1.txt")
                .Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            File.Delete("result1.txt");
            for (int i = 0; i < input.Length; i++)
            {


                if (input[i] == "stop")
                {
                    foreach (var item in resources)
                    {
                        File.AppendAllText("result1.txt", item.Key + " -> " + item.Value+Environment.NewLine);
                    }
                    break;
                }
                else if (i % 2 == 0)
                {
                    materials = input[i];
                }
                else
                {
                    quantity = int.Parse(input[i]);
                    if (resources.ContainsKey(materials))
                    {
                        resources[materials] += quantity;
                    }
                    else
                    {
                        resources.Add(materials, quantity);
                    }

                }

            }
        }
    }
}
