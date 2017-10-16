using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int k = numbers.Length / 4;
            int[] row1Left = numbers.Take(k).Reverse().ToArray();
            int[] row1Right = numbers.Reverse().Take(k).ToArray();
            int[] row1 = row1Left.Concat(row1Right).ToArray();
            int[] row2 = numbers.Skip(k).Take(2 * k).ToArray();
            var sum = row1.Select((x,index) => x+row2[index]);
            Console.WriteLine(string.Join(" ",sum));
            
        }
    }
}
