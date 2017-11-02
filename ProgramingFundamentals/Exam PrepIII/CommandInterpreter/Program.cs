using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] command = Console.ReadLine()
                .Split(' ')
                .ToArray();
            while (command[0] != "end")
            {

                if (command[0] == "reverse")
                {
                    int start = int.Parse(command[2]);
                    int count = int.Parse(command[4]);
                    int lastIndex = start + count-1;
                    if (start >= 0 && start <= numbers.Length-1 && start+count-1 < numbers.Length && count >= 0)
                    {
                        for (int i = 0; i < count / 2; i++)
                        {
                            string tempNumber = numbers[start];
                            numbers[start] = numbers[lastIndex];
                            numbers[lastIndex] = tempNumber;
                            lastIndex--;
                            start++;
                        } 
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input parameters.");
                    }
                    
                }
                else if (command[0] == "sort")
                {
                    if (int.Parse(command[2]) >= 0 && int.Parse(command[2]) <= numbers.Length - 1 && int.Parse(command[2]) + int.Parse(command[4]) - 1 < numbers.Length && int.Parse(command[4])>=0)
                    {
                        var leftSide = numbers.Take(int.Parse(command[2]));
                        var middleSide = numbers.Skip(int.Parse(command[2])).Take(int.Parse(command[4])).OrderBy(x => x);
                        var rightSide = numbers.Skip(int.Parse(command[2]) + int.Parse(command[4]));
                        var allItems = leftSide.Concat(middleSide).Concat(rightSide);
                        int index = 0;
                        foreach (var item in allItems.ToArray())
                        {
                            numbers[index++] = item;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input parameters.");
                    }
                    
                }
                else if (command[0] == "rollLeft")
                {
                    if (int.Parse(command[1]) >= 0)
                    {
                        for (int g = 0; g < int.Parse(command[1]); g++)
                        {
                            string tempNumber = numbers[0];
                            for (int i = 0; i < numbers.Length - 1; i++)
                            {

                                numbers[i] = numbers[(i + 1) % numbers.Length];

                            }
                            numbers[numbers.Length - 1] = tempNumber;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input parameters.");
                    }


                }
                else if (command[0] == "rollRight")
                {
                    if (int.Parse(command[1]) >= 0)
                    {
                        for (int g = 0; g < int.Parse(command[1]); g++)
                        {
                            string tempNumber = numbers[numbers.Length - 1];
                            for (int i = numbers.Length - 1; i > 0; i--)
                            {

                                numbers[i] = numbers[i - 1];

                            }
                            numbers[0] = tempNumber;
                        }
                    }
                    
                    else
                    {
                        Console.WriteLine($"Invalid input parameters.");
                    }

                }




                command = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
