using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beverage_labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var productName = Console.ReadLine();
            var productVolume = double.Parse(Console.ReadLine());
            var energyPerHundred = int.Parse(Console.ReadLine());
            var sugarPerHundred = int.Parse(Console.ReadLine());

            var energy = energyPerHundred * (productVolume / 100);
            var sugar = sugarPerHundred * (productVolume / 100);

            Console.WriteLine($"{productVolume}ml {productName}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");


        }
    }
}
