using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            SortedDictionary<double,int> result = new SortedDictionary<double, int>();

            foreach (var item in numbers)
            {
                if (result.ContainsKey(item))
                {
                    result[item]++;
                }
                else
                {
                    result[item] = 1;
                }
            }
            foreach (var item in result.Keys)
            {
                Console.WriteLine($"{item} -> {result[item]}");
            }
        }
    }
}
