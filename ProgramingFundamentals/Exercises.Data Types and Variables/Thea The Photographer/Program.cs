using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPicturesTaken = long.Parse(Console.ReadLine());
            long filterTimeInSeconds = long.Parse(Console.ReadLine());
            long percentOfUsefulPictures = long.Parse(Console.ReadLine());
            long uploadTimeNeeded = long.Parse(Console.ReadLine());

            long usefulPictures = (long)Math.Ceiling(numberOfPicturesTaken * percentOfUsefulPictures / 100.0);

            long totalFilterTimeInSeconds = (long)((numberOfPicturesTaken * filterTimeInSeconds) + ((long)usefulPictures * uploadTimeNeeded));



            TimeSpan span = TimeSpan.FromSeconds(totalFilterTimeInSeconds);
            string result = span.ToString(@"d\:hh\:mm\:ss");


            Console.WriteLine($"{result}");

        }
    }
}
