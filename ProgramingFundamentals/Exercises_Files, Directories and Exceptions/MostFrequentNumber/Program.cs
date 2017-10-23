using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = File.ReadAllText("input3.txt").Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Dictionary<int,int> result = new Dictionary<int, int>();
            File.Delete("result3.txt");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!result.ContainsKey(numbers[i]))
                {
                    result.Add(numbers[i],1);
                }
                else
                {
                    result[numbers[i]]++;
                }
            }
            int mostFrequent = result.Values.Max();
            foreach (var item in result)
            {
                if (item.Value == mostFrequent)
                {
                    File.AppendAllText("result3.txt",item.Key.ToString());
                    break;
                }
            }
        }
    }
}
