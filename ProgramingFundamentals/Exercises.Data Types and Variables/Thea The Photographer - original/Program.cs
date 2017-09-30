using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_The_Photographer__original
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

            long totalFilterTimeInSeconds = (numberOfPicturesTaken * filterTimeInSeconds) + ((long)usefulPictures * uploadTimeNeeded);

            long days = totalFilterTimeInSeconds / (60 * 60 * 24);
            totalFilterTimeInSeconds -= days * 60 * 60 * 24;
            long hours = totalFilterTimeInSeconds / (60 * 60);
            totalFilterTimeInSeconds -= hours * 60 * 60;
            long minutes = totalFilterTimeInSeconds / 60;
            totalFilterTimeInSeconds -= minutes * 60;

            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{totalFilterTimeInSeconds:D2}");

        }
    }
}
