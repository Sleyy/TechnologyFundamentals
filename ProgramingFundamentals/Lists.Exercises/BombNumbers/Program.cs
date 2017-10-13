using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> bombs = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]==bombs[0])
                {

                    if (i + bombs[1] > numbers.Count-1 && i - bombs[1] < 0)
                    {
                        numbers.RemoveRange(0, numbers.Count);
                    }
                    else if (i+ bombs[1] > numbers.Count-1)
                    {
                        numbers.RemoveRange(i - bombs[1], (((bombs[1] * 2) + 1)-(numbers.Count- i)));
                    }
                    else if (i - bombs[1] < 0)
                    {
                        numbers.RemoveRange(0, (bombs[1] * 2) + 1-(bombs[1]-i));
                    }
                    
                    else
                    {
                        numbers.RemoveRange(i - bombs[1], (bombs[1] * 2) + 1);
                    }
                    i = 0;

                }
            }

            Console.WriteLine(numbers.Sum());

        }
    }
}
