using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();
            List<long> hornets = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            
            

            for (int i = 0; i < beehives.Count; i++ )
            {
                
                if (hornets.Count ==0)
                {
                    break;
                }
                if (beehives[i] >= hornets.Sum())
                {
                    beehives[i] -= hornets.Sum();
                    hornets.RemoveAt(0);
                }
                else
                {
                    beehives[i] = 0;
                }
                
                
            }

            bool hasHives = false;
            foreach (var hive in beehives)
            {
                if (hive >0)
                {
                    Console.Write($"{hive} ");
                    hasHives = true;
                }
            }
            if (!hasHives)
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
            
        }
    }
}
