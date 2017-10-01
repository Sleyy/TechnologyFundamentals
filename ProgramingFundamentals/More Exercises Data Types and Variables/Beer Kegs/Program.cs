using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfKegs = sbyte.Parse(Console.ReadLine());
            double biggestKeg = 0;
            string bestKeg = "";
            
            for (int i = 0; i < numberOfKegs; i++)
            {
                string modelOfKeg = Console.ReadLine();
                double radiusOfKeg = double.Parse(Console.ReadLine());
                int heightOfKeg = int.Parse(Console.ReadLine());
                double kegVolume = Math.PI * radiusOfKeg * radiusOfKeg * heightOfKeg;
                
                if (kegVolume > biggestKeg)
                {
                    bestKeg = modelOfKeg;
                    biggestKeg = kegVolume;
                }
            }
            Console.WriteLine(bestKeg);
        }
    }
}
