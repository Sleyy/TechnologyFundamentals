using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_In_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(GetNumberInReverse(number));

        }

        static string GetNumberInReverse(string number)
        {
            string result = "";
            int numberLength = number.Length;
            for (int i = 0; i < numberLength; i++)
            {
                result += number.Substring(number.Length - 1);
                number = number.Remove(number.Length - 1);
            }
            return result;
        }
    }
}
