using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceOfCommands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();


            string command = "";
            while (!command.Equals("stop"))
            {
                command = Console.ReadLine().Trim();
                int[] args = new int[2];

                if (command.Contains("add") ||
                    command.Contains("subtract") ||
                    command.Contains("multiply"))
                {
                    string[] stringParams = command.Split(ArgumentsDelimiter);
                    command = stringParams[0];
                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);

                    
                    PerformAction(array, command, args);
                }
                else if(command != "stop")
                {
                    PerformAction(array, command, args);
                }
            }
        }

        static void PerformAction(long[] array, string action, int[] args)
        {
            
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos-1] *= value;
                    break;
                case "add":
                    array[pos-1] += value;
                    break;
                case "subtract":
                    array[pos-1] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
            Console.WriteLine(string.Join(" ",array));
            
        }

        private static void ArrayShiftRight(long[] array)
        {
            long a = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = a;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long a = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length-1] = a;
        }

        
    }
}
