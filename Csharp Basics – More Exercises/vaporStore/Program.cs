using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string gameName = " ";
            double spent = 0.0;

            while (gameName != "Game Time")
            {
                gameName = Console.ReadLine();

                if (currentBalance <= 0)
                {
                    Console.WriteLine($"Out of money!");
                    break;
                }
                
                if (gameName == "OutFall 4")
                {
                    if (currentBalance - 39.99 >= 0)
                    {
                        currentBalance -= 39.99;
                        spent += 39.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                   
                }
                else if (gameName == "CS: OG")
                {
                    if (currentBalance - 15.99 >= 0)
                    {
                        currentBalance -= 15.99;
                        spent += 15.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "Zplinter Zell")
                {
                    if (currentBalance - 19.99 >= 0)
                    {
                        currentBalance -= 19.99;
                        spent += 19.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "Honored 2")
                {
                    if (currentBalance - 59.99 >= 0)
                    {
                        currentBalance -= 59.99;
                        spent+=59.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "RoverWatch")
                {
                    if (currentBalance - 29.99 >= 0)
                    {
                        currentBalance -= 29.99;
                        spent += 29.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    if (currentBalance - 39.99 >= 0)
                    {
                        currentBalance -= 39.99;
                        spent += 39.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                else if (gameName == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${currentBalance:f2}");
                }
                else  
                {
                    Console.WriteLine("Not Found");
                }
                
                

            }
        }
    }
}
