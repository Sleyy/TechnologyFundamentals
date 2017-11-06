using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> cache = new Dictionary<string, Dictionary<string, int>>();

            string[] input = Console.ReadLine()
                .Split(new string[] { " ", "-", ">", "|", "\t" }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (input[0] != "thetinggoesskrra")
            {
                string dataSet = string.Empty;
                string dataKey = string.Empty;
                int dataSize = 0;
                if (input.Length == 1)
                {
                    dataSet = input[0];
                    data.Add(dataSet, new Dictionary<string, int>());
                    if (cache.ContainsKey(dataSet))
                    {
                        foreach (var box in cache)
                        {
                            foreach (var f in box.Value)
                            {
                                data[dataSet].Add(f.Key,f.Value);
                            }
                        }
                    }
                }
                else
                {
                    dataKey = input[0];
                    dataSize = int.Parse(input[1]);
                    dataSet = input[2];
                    if (data.ContainsKey(dataSet))
                    {
                        data[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            cache.Add(dataSet, new Dictionary<string, int>());
                            cache[dataSet].Add(dataKey, dataSize);
                        }
                        else
                        {
                            cache[dataSet].Add(dataKey,dataSize);
                        }
                        
                    }


                }

                input = Console.ReadLine()
                    .Split(new string[] { " ", "-", ">", "|","\t" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
            BigInteger sum = 0;
            BigInteger totalSum = 0;
            var firstKey = string.Empty;
            if (data.Count != 0)
            {
               
                
                foreach (var box in data)
                {
                    sum = 0;
                    foreach (var b in box.Value)
                    {
                       
                            sum += b.Value;
                       
                    }
                    if (sum > totalSum)
                    {
                        totalSum = sum;
                         firstKey = box.Key;

                    }
                }
                
                foreach (var d in data)
                {
                    if (d.Key == firstKey)
                    {
                        Console.WriteLine($"Data Set: {d.Key}, Total Size: {totalSum}");
                        foreach (var f in d.Value)
                        {
                            Console.WriteLine($"$.{f.Key}");
                        }
                    }

                }
            }
            
        }
    }
}
