using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int lastChar = int.Parse(Console.ReadLine());

            for (int i = startChar; i <= lastChar; i++)
            {
                Console.Write($"{(char)i} ");
            }


        }
    }
}
