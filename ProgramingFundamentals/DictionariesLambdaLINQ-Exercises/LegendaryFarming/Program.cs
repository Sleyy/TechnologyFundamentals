using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendarys = new Dictionary<string, int>();
            Dictionary<string, int> trashMaterials = new Dictionary<string, int>();
            bool legendaryObtained = false;

            legendarys.Add("fragments",0);
            legendarys.Add("motes", 0);
            legendarys.Add("shards", 0);
            while (!legendaryObtained)
            {
                string[] input = Console.ReadLine().ToLower()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 1; i < input.Length; i += 2)
                {
                    if (input[i]=="fragments" || input[i] == "shards" || input[i] == "motes")
                    {
                        legendarys[input[i]] += int.Parse(input[i - 1]);
                        if (legendarys["fragments"] >= 250)
                        {
                            legendarys["fragments"] -= 250;
                            legendaryObtained = true;
                            Console.WriteLine("Valanyr obtained!");
                            break;

                        }
                        else if (legendarys["shards"] >= 250)
                        {
                            legendarys["shards"] -= 250;
                            legendaryObtained = true;
                            Console.WriteLine("Shadowmourne obtained!");
                            break;

                        }
                        else if (legendarys["motes"] >= 250)
                        {
                            legendarys["motes"] -= 250;
                            legendaryObtained = true;
                            Console.WriteLine("Dragonwrath obtained!");
                            break;

                        }
                    }
                    else
                    {
                        if (!trashMaterials.ContainsKey(input[i]))
                        {
                            trashMaterials.Add(input[i], int.Parse(input[i - 1]));
                        }
                        else
                        {
                            trashMaterials[input[i]] += int.Parse(input[i - 1]);
                        }
                    }
                }
            }
            foreach (var material in legendarys.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
            foreach (var trashMaterial in trashMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{trashMaterial.Key}: {trashMaterial.Value}");
            }
        }

    }
}


