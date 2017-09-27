using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = -1;

            


            for (int i = 1; i <= 4; i++)
            {
                for (int g = 1; g <= 4; g++)
                {
                    for (int f = 1; f <= 4; f++)
                    {
                        counter++;
                        if (counter % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                        if (i+g+f >= number)
                        {
                            Console.Write("O");
                        }
                        else
                        {
                            Console.Write("X");
                        }
                        if (i == 1)
                        {
                            Console.Write("A");
                        }
                        else if (i == 2)
                        {
                            Console.Write("C");
                        }
                        else if (i == 3)
                        {
                            Console.Write("G");
                        }
                        else if (i == 4)
                        {
                            Console.Write("T");
                        }
                        if (g == 1)
                        {
                            Console.Write("A");
                        }
                        else if (g == 2)
                        {
                            Console.Write("C");
                        }
                        else if (g == 3)
                        {
                            Console.Write("G");
                        }
                        else if (g == 4)
                        {
                            Console.Write("T");
                        }
                        if (f == 1)
                        {
                            Console.Write("A");
                        }
                        else if (f == 2)
                        {
                            Console.Write("C");
                        }
                        else if (f == 3)
                        {
                            Console.Write("G");
                        }
                        else if (f == 4)
                        {
                            Console.Write("T");
                        }
                        if (i + g + f >= number)
                        {
                            Console.Write("O ");
                        }
                        else
                        {
                            Console.Write("X ");
                        }



                    }
                }
            }
        }
    }
}
