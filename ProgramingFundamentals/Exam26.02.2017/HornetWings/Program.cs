using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int flaps = int.Parse(Console.ReadLine());
            double distanceInMetersPer1kFlaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            int flapsPerSecond = 100;

            int totalFlapSeconds = flaps / flapsPerSecond + ((flaps / endurance) * 5);
            double distance = distanceInMetersPer1kFlaps * flaps/1000;

            Console.WriteLine($"{distance:f2} m.\r\n{totalFlapSeconds} s.");
        }
    }
}
