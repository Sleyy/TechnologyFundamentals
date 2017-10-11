using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|').ToList();
            List<int> resuList = new List<int>();

            for (int i = numbers.Count-1; i >= 0; i--)
            {
                List<int> elements = numbers[i].Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                resuList.AddRange(elements);
            }
            Console.WriteLine(string.Join(" ",resuList));
        }
    }
}
