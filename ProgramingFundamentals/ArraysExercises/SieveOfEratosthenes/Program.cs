using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var array = new bool[n+1];

            for (int i = 2; i <= n; i++)
            {
                array[i] = true;
            }
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (array[i] == true)
                {
                    for (int j = (i * i); j <= n; j += i)
                    {
                        array[j] = false;
                    }

                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
