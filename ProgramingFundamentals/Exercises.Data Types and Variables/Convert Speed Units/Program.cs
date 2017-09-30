using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalSeconds = seconds + (minutes * 60) + (hours * 3600);

            float metersPerSecond = distanceInMeters / totalSeconds;
            float kilometersPerHour = ((distanceInMeters/1000) / (totalSeconds/3600));
            float milesPerHour = ((distanceInMeters / 1609) / (totalSeconds / 3600));

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);




        }
    }
}
