using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            while (true)
            {
                var command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "add")
                {
                    numbers.Insert(int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "addMany")
                {
                    for (int i = command.Length - 1; i > 1; i--)
                    {

                        numbers.Insert(int.Parse(command[1]), int.Parse(command[i]));
                    }
                }
                else if (command[0] == "contains")
                {
                    bool indexFound = false;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == int.Parse(command[1]))
                        {
                            Console.WriteLine(i);
                            indexFound = true;
                            break;
                        }
                    }
                    if (!indexFound)
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (command[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "shift")
                {
                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        numbers.Insert(numbers.Count,numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }
                else if (command[0]=="sumPairs")
                {
                    int cycles = (numbers.Count / 2);
                    for (int i = 0; i < cycles; i++)
                    {
                        int sum = numbers[i] + numbers[i + 1];
                        numbers.RemoveRange(i,2);
                        numbers.Insert(i,sum);
                    }
                }
                else if (command[0]=="print")
                {
                    Console.WriteLine($"[{string.Join(", ",numbers)}]");
                    break;
                }
            }
        }
    }
}
