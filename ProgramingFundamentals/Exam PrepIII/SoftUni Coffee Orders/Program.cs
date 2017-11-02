using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < numberOfOrders; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime date= DateTime.ParseExact(Console.ReadLine(),"d/M/yyyy",CultureInfo.InvariantCulture);
                decimal capsuleCount = decimal.Parse(Console.ReadLine());
               
                int daysInMonth = DateTime.DaysInMonth(date.Year,date.Month);
                decimal currentSum = (daysInMonth * capsuleCount) * price;
                Console.WriteLine($"The price for the coffee is: ${currentSum:f2}");
                sum += currentSum;

            }
            Console.WriteLine($"Total: ${sum:f2}");

        }
    }
}
