using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_Of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();
            if (valueType == "int")
            {
                int firstValue = int.Parse(Console.ReadLine());
                int secondValue = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstValue,secondValue));
            }
            else if (valueType == "char")
            {
                char firstValue = char.Parse(Console.ReadLine());
                char secondValue = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstValue, secondValue));
            }
            else
            {
                string firstValue = Console.ReadLine();
                string secondValue = Console.ReadLine();
                Console.WriteLine(GetMax(firstValue, secondValue));
            }
        }

        static int GetMax(int firstValue,int secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }

        static char GetMax(char firstValue, char secondValue)
        {
            if (firstValue > secondValue)
            {
                return (char)firstValue;
            }
            else
            {
                return (char)secondValue;
            }
        }

        static string GetMax(string firstValue, string secondValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
    }
}
