using System;
using System.Collections.Generic;
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
            while (true)
            {
                lineCounter++;
                string input = Console.ReadLine();
                
                if (input == "stop")
                {
                    foreach (var item in resources)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    break;
                }
                else if (lineCounter % 2 != 0)
                {
                    materials = input;
                }
                else
                {
                    quantity = int.Parse(input);
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
            
            ;
        }
    }
}
