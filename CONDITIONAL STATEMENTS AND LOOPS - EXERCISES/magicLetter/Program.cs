using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char g = firstLetter; g <= secondLetter; g++)
                {
                    for (char f = firstLetter; f <= secondLetter; f++)
                    {
                        if (i != thirdLetter && g != thirdLetter && f !=thirdLetter)
                        {
                            Console.Write($"{i}{g}{f} ");
                        }
                    }
                }
            }

        }
    }
}
