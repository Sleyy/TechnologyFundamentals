using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().ToCharArray();
            var secondArray = Console.ReadLine().ToCharArray();
            bool equal = true;
            
            for (int i = 0; i < Math.Min(firstArray.Length,secondArray.Length); i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    equal = false;
                    break;
                }
            }
            if (equal)
            {
                if (firstArray.Length< secondArray.Length)
                {
                    Console.WriteLine(string.Join("", firstArray).Replace(" ", ""));
                    Console.WriteLine(string.Join("", secondArray).Replace(" ", ""));
                }
                else if (secondArray.Length<firstArray.Length)
                {
                    Console.WriteLine(string.Join("", secondArray).Replace(" ", ""));
                    Console.WriteLine(string.Join("", firstArray).Replace(" ", ""));
                }
                else
                {
                    Console.WriteLine(string.Join("", firstArray).Replace(" ", ""));
                    Console.WriteLine(string.Join("", secondArray).Replace(" ", ""));
                }
            }
            else if(!equal)
            {
               
                
                if (firstArray[0] > secondArray[0])
                {
                    Console.WriteLine(string.Join("", secondArray).Replace(" ", ""));
                    Console.WriteLine(string.Join("", firstArray).Replace(" ", ""));
                }
                else
                {
                    Console.WriteLine(string.Join("", firstArray).Replace(" ", ""));
                    Console.WriteLine(string.Join("", secondArray).Replace(" ", ""));
                }
            }

        }
    }
}
