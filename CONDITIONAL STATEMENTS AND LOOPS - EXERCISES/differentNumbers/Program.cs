using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace differentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            bool combination = false;
            for (int i = numberOne; i <= numberTwo; i++)
            {
                for (int g = numberOne; g <= numberTwo; g++)
                {
                    for (int f = numberOne; f <= numberTwo; f++)
                    {
                        for (int d = numberOne; d <= numberTwo; d++)
                        {
                            for (int s = numberOne; s <= numberTwo; s++)
                            {
                                if (numberOne <= i && i < g && g < f && f < d && d < s && s <= numberTwo)
                                {
                                    Console.WriteLine($"{i} {g} {f} {d} {s}");
                                    combination = true;
                                }
                            }
                        }
                    }
                }
            }
            if (combination == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
