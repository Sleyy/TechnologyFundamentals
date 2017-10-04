using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_A_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            FilledSquareHeader(number);
            FilledSquareBody(number);
            FilledSquareHeader(number);
        }

        static void FilledSquareHeader(int number)
        {
            Console.WriteLine(new string('-', number * 2));
            
        }

        static void FilledSquareBody(int number)
        {
            for (int i = 1; i <= number-2; i++)
            {
                Console.Write("-");
                for (int g = 1; g < number; g++)
                {

                    Console.Write("\\/");

                }
                Console.WriteLine("-");
            }
            
        }
        
        
    }
}
