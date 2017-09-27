using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffession = Console.ReadLine();
            string drink;

            if (proffession == "Athelete")
            {
                drink = "Water";
            }
            else if (proffession == "Businessman" || proffession == "Businesswoman")
            {
                drink = "Coffee";
            }
            else if (proffession == "SoftUni Student")
            {
                drink = "Beer";
            }
            else  
            {
                drink = "Tea";
            }
            Console.WriteLine(drink);
        }
    }
}
