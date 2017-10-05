using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMaxNumber(firstNumber, secondNumber, thirdNumber));

        }

        static int GetMaxNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int maxNumber = (Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber));
            return maxNumber;
            
        }
    }
}
