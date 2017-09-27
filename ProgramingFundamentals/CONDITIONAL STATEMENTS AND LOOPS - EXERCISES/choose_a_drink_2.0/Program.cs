using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace choose_a_drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffession = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            double price = 0.0;

            if (proffession == "Athlete")
            {
                price = 0.70;
                Console.WriteLine($"The {proffession} has to pay {(price*number):f2}.");
            }
            else if (proffession == "Businessman" || proffession == "Businesswoman")
            {
                price = 1.00;
                Console.WriteLine($"The {proffession} has to pay {(price * number):f2}.");
            }
            else if (proffession == "SoftUni Student")
            {
                price = 1.70;
                Console.WriteLine($"The {proffession} has to pay {(price * number):f2}.");
            }
            else
            {
                price = 1.20;
                Console.WriteLine($"The {proffession} has to pay {(price * number):f2}.");
            }

            
        }
    }
}
