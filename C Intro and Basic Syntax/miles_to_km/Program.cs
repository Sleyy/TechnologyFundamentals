using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miles_to_km
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfMiles = double.Parse(Console.ReadLine());
            var kilometers = numberOfMiles * 1.60934;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
