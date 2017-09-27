using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int mainDigit = 0;
            int offset = 0;
            int digitLength = 0;
            for (int i = 0; i < n; i++)
            {
                int key = int.Parse(Console.ReadLine());

                if (key > 1000)
                {
                    digitLength = 4;
                    mainDigit = key / 1000;
                }
                else if (key > 100)
                {
                    digitLength = 3;
                    mainDigit = key / 100;   
                }
                else if (key > 10 && key < 100)
                {
                    digitLength = 2;
                    mainDigit = key / 10;
                }
                else
                {
                    digitLength = 1;
                    mainDigit = key;
                }

                offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                if (key == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write($"{(char)(offset + digitLength + 96)}");
                }
                
            }
        }
    }
}
