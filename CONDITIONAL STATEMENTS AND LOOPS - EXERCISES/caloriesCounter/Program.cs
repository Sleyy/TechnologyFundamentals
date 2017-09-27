using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            int caloriesCounter = 0;
            for (int i = 1; i <= numberOfProducts; i++)
            {
                string product = Console.ReadLine().ToLower();

                if (product == "cheese")
                {
                    caloriesCounter += 500;
                }
                else if (product == "tomato sauce")
                {
                    caloriesCounter += 150;
                }
                else if (product == "salami")
                {
                    caloriesCounter += 600;
                }
                else if (product == "pepper")
                {
                    caloriesCounter += 50;
                }
            }
            Console.WriteLine($"Total calories: {caloriesCounter}");
        }
    }
}
