using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
           Random rnd = new Random();

            for (int pos1 = 0; pos1 < input.Length-1; pos1++)
            {
                int pos2 = rnd.Next(0, input.Length);
                string tempInput = input[pos1];
                input[pos1] = input[pos2];
                input[pos2] = tempInput;
            }
            foreach (var word in input)
            {
                Console.WriteLine(string.Join(" ",word));
            }
        }
    }
}
