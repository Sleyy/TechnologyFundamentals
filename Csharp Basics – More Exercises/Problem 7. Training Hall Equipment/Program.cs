using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());

            double sum = 0.0;
            for (int i = 0; i < numberOfItems; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                if (itemCount > 1)
                {
                    itemName = itemName + 's';
                }
                sum += itemPrice * itemCount;
                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
            }

            Console.WriteLine($"Subtotal: ${sum:f2}");
            if (budget - sum >=0)
            {
                Console.WriteLine($"Money left: ${(budget-sum):f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${(sum - budget):f2} more.");
            }
            


        }
    }
}
