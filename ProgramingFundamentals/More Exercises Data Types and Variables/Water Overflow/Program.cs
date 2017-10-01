using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            short numberOfPours = byte.Parse(Console.ReadLine());
            short tankCapacity = 0;
            for (int i = 0; i < numberOfPours; i++)
            {
                short amountOfWater = short.Parse(Console.ReadLine());
                if (tankCapacity + amountOfWater > 255)
                {
                    Console.WriteLine($"Insufficient capacity!");
                }
                else
                {
                    tankCapacity += amountOfWater;
                }
            }
            Console.WriteLine(tankCapacity);
        }
    }
}
