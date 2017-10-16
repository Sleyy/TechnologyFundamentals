using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, Dictionary<String, long>>();
            

            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] splitInput = input.Split(new String[] {"|"}, StringSplitOptions.RemoveEmptyEntries);
                if (!result.ContainsKey(splitInput[1]))
                {
                    result.Add(splitInput[1], new Dictionary<string, long>());
                }
                if (!result[splitInput[1]].ContainsKey(splitInput[0]))
                {
                    result[splitInput[1]].Add(splitInput[0], int.Parse(splitInput[2]));
                }
                else
                {
                    result[splitInput[1]][splitInput[0]]+= int.Parse(splitInput[2]);
                }
                input = Console.ReadLine();
            }

            foreach (var country in result.OrderByDescending(x=>x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }

        }
    }
}
