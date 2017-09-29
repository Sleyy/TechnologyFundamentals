using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Tripple_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97+number; i++)
            {
                for (int g = 97; g < 97+number; g++)
                {
                    for (int f = 97; f < 97+number; f++)
                    {
                        Console.WriteLine($"{(char)i}{(char)g}{(char)f}");
                    }
                }
            }
        }
    }
}
