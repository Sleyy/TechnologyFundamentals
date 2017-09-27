using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            for (int i = numOne; i >= 1; i--)
            {
                for (int g = 1; g <= numTwo; g++)
                {
                    sum += (i * g) * 3;
                    counter++;
                    if (sum >= boundary)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {boundary}");
                        return;
                    }
                }
            }
            if (sum < boundary)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
