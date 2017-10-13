using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
           
            
            while (true)
            {
                List<string> command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (command[0] == "Delete")
                {
                    int deleteNumber = int.Parse(command[1]);
                    numbers.RemoveAll(item => item == deleteNumber);
                }
                else if (command[0] =="Insert")
                {
                    int element = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index,element);
                }
                else if (command[0]== "Odd")
                {
                    foreach (var odd in numbers)
                    {
                        if (odd % 2 != 0)
                        {
                            Console.Write($"{odd} ");
                        } 
                    }
                    break;
                }
                else if (command[0] == "Even")
                {
                    foreach (var even in numbers)
                    {
                        if (even % 2 == 0)
                        {
                            Console.Write($"{even} ");
                        }
                    }
                    break;
                }
                
            }
            

        }
    }
}
