using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeOfLeaving = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            long numberOfStepsToHome = long.Parse(Console.ReadLine());
            long timePerStep = long.Parse(Console.ReadLine());

            BigInteger totalStepTimeSeconds = numberOfStepsToHome * timePerStep;
            long minutes = (long)totalStepTimeSeconds / 60;
            long seconds = (long)totalStepTimeSeconds % 60;
            long hours = minutes / 60;
            minutes = minutes % 60;
            hours = hours % 24;
            
            timeOfLeaving = timeOfLeaving.AddSeconds(seconds).AddMinutes(minutes).AddHours(hours);
            Console.WriteLine($"Time Arrival: {timeOfLeaving.ToString("HH:mm:ss")}");


        }
    }
}
