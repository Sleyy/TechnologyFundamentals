using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Name_Of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(GetName(number));
        }

        static string GetName(string number)
        {
            string lastDigit = number.Substring(number.Length - 1);
            string name = "";
            if (lastDigit == "0")
            {
                name = "zero";
            }
            else if (lastDigit == "1")
            {
                name = "one";
            }
            else if (lastDigit == "2")
            {
                name = "two";
            }
            else if (lastDigit == "3")
            {
                name = "three";
            }
            else if (lastDigit == "4")
            {
                name = "four";
            }
            else if (lastDigit == "5")
            {
                name = "five";
            }
            else if (lastDigit == "6")
            {
                name = "six";
            }
            else if (lastDigit == "7")
            {
                name = "seven";
            }
            else if (lastDigit == "8")
            {
                name = "eight";
            }
            else if (lastDigit == "9")
            {
                name = "nine";
            }

            return name;
        }
    }
}
