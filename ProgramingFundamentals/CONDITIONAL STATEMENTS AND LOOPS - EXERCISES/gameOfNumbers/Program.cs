using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            bool magic = false;
            int magicOne = 0;
            int magicTwo = 0;
            for (int i = numOne; i <= numTwo; i++)
            {
                for (int g = numOne; g <= numTwo; g++)
                {
                    counter++;
                    if (i+g == magicNum)
                    {
                        magicOne = i;
                        magicTwo = g;
                        magic = true;
                        
                    }
                }
            }
            if (magic == true)
            {
                Console.WriteLine($"Number found! {magicOne} + {magicTwo} = {magicNum}");
            }

            else if (magic == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
