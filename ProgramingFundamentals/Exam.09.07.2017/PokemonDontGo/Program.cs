using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int sum = 0;
            while (sequence.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int indexedNumber = 0;
                if (index < 0)
                {
                    index = 0;
                    indexedNumber = sequence[index];
                    sequence.Insert(0, sequence.Last());
                    sequence.RemoveAt(index + 1);

                }
                else if (index > sequence.Count - 1)
                {
                    index = sequence.Count - 1;
                    indexedNumber = sequence[index];
                    sequence.RemoveAt(index);
                    sequence.Insert(index, sequence.First());

                }
                else
                {
                    indexedNumber = sequence[index];
                    sequence.RemoveAt(index);

                }




                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] <= indexedNumber)
                    {
                        sequence[i] += indexedNumber;
                    }
                    else
                    {
                        sequence[i] -= indexedNumber;
                    }

                }
                sum += indexedNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
