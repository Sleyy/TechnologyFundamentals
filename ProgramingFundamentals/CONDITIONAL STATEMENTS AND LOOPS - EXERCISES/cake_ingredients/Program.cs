using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cake_ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = "";
            int counter = 0;
            while (ingredient != "Bake!")
            {
                ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    break;
                }
                counter++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");




        }
    }
}
