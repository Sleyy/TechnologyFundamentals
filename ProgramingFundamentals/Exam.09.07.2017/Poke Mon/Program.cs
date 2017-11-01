using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            int counter = 0;
            double pokePowerOriginalValue = (double)pokePower * 0.5;
            while (pokePower >= distance)
            {
                pokePower -= distance;
                if (pokePower == pokePowerOriginalValue && exhaustion != 0)
                {
                    pokePower /= exhaustion;
                }
                counter++;
            }
            Console.WriteLine($"{pokePower}\r\n{counter}");
        }
    }
}
