using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace photoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double photoSize = int.Parse(Console.ReadLine());
            int photoWidth = int.Parse(Console.ReadLine());
            int photoHeight = int.Parse(Console.ReadLine());


            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");

            if (photoSize < 1000)
            {
                Console.WriteLine($"Size: {photoSize}B");
            }
            else if (photoSize >= 1000 && photoSize <= 1000000)
            {
                Console.WriteLine($"Size: {photoSize/1000}KB");
            }
            else if (photoSize >= 1000000 )
            {
                Console.WriteLine($"Size: {photoSize/1000000}MB");
            }

            Console.Write($"Resolution: {photoWidth}x{photoHeight} ");

            if (photoWidth == photoHeight)
            {
                Console.WriteLine($"(square)");
            }
            else if (photoWidth > photoHeight)
            {
                Console.WriteLine($"(landscape)");
            }
            else if (photoWidth < photoHeight)
            {
                Console.WriteLine($"(portrait)");
            }
        }
    }
}
