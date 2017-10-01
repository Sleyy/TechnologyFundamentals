using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnits = Console.ReadLine();
            double valueToConvert = double.Parse(Console.ReadLine());

            if (imperialUnits == "miles")
            {
                Console.WriteLine($"{valueToConvert} {imperialUnits} = {valueToConvert*1.6:f2} kilometers");
            }
            else if(imperialUnits == "inches")
            {
                Console.WriteLine($"{valueToConvert} {imperialUnits} = {valueToConvert * 2.54:f2} centimeters");
            }
            else if (imperialUnits == "feet")
            {
                Console.WriteLine($"{valueToConvert} {imperialUnits} = {valueToConvert * 30:f2} centimeters");
            }
            else if (imperialUnits == "yards")
            {
                Console.WriteLine($"{valueToConvert} {imperialUnits} = {valueToConvert * 0.91:f2} meters");
            }
            else if (imperialUnits == "gallons")
            {
                Console.WriteLine($"{valueToConvert} {imperialUnits} = {valueToConvert * 3.8:f2} liters");
            }
        }
    }
}
