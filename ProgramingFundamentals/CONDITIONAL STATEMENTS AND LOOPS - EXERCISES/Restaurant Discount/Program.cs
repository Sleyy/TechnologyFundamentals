using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hall ;
            double price = 0.0;

            
             if (groupSize <= 50)
            {
                hall = "Small Hall";
                price += 2500;
                Console.WriteLine($"We can offer you the {hall}");
            }
            else if (groupSize <=100)
            {
                hall = "Terrace";
                price += 5000;
                Console.WriteLine($"We can offer you the {hall}");
            }
            else if (groupSize <= 120)
            {
                hall = "Great Hall";
                price += 7500;
                Console.WriteLine($"We can offer you the {hall}");
            }

            if (package == "Normal")
            {
                price += 500;
                price *= 0.95;
            }
            else if (package == "Gold")
            {
                price += 750;
                price *= 0.90;
            }
            else if (package == "Platinum")
            {
                price += 1000;
                price *= 0.85;
            }

            var pricePerPerson = price / groupSize;

            if (groupSize > 120)
            {
                Console.WriteLine($"We do not have an appropriate hall.");

            }
            else
            {
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }

            
            
        }
    }
}
