using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine()
                .Split(' ')
                .ToArray();
            double[] zones = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            int[] checkpointIndex = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < drivers.Length; i++)
            {
                double currentFuel = drivers[i][0];
                int zoneCounter = 0;
                for (int g = 0; g < zones.Length; g++)
                {
                    
                    if (checkpointIndex.Contains(g))
                    {
                        currentFuel += zones[g];
                        zoneCounter++;
                    }
                    else
                    {
                        currentFuel -= zones[g];
                        zoneCounter++;
                    }
                    if (currentFuel <= 0)
                    {
                        zoneCounter--;
                        break;
                    }
                }
                if (currentFuel > 0)
                {
                    Console.WriteLine($"{drivers[i]} - fuel left {currentFuel:f2}");
                }
                else 
                {
                    Console.WriteLine($"{drivers[i]} - reached {zoneCounter}");
                }

            }
            
        }
    }
}
