using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (integers.Length == 1)
            {
                Console.WriteLine($"{{ {integers[0]} }}");
            }
            else if (integers.Length % 2 == 0)
            {
                Console.WriteLine($"{{ {integers[integers.Length/2-1]}, {integers[integers.Length / 2]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {integers[integers.Length / 2 - 1]}, {integers[integers.Length / 2 ]}, {integers[integers.Length / 2 + 1]} }}");
            }
        }
    }
}
