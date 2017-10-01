using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catch_The_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            sbyte numberOfIds = sbyte.Parse(Console.ReadLine());
            long currentNumber = long.MinValue;

            if (numeralType == "sbyte")
            {
                for (int i = 0; i < numberOfIds; i++)
                {
                    long idNumber = long.Parse(Console.ReadLine());

                    if (idNumber >= currentNumber && idNumber>= sbyte.MinValue && idNumber <= sbyte.MaxValue)
                    {
                        currentNumber = idNumber;
                    }
                }
            }
            else if (numeralType == "int")
            {
                for (int i = 0; i < numberOfIds; i++)
                {
                    long idNumber = long.Parse(Console.ReadLine());

                    if (idNumber >= currentNumber && idNumber >= int.MinValue && idNumber <= int.MaxValue)
                    {
                        currentNumber = idNumber;
                    }
                }
            }
            else if (numeralType == "long")
            {
                for (int i = 0; i < numberOfIds; i++)
                {
                    long idNumber = long.Parse(Console.ReadLine());

                    if (idNumber >= currentNumber && idNumber >= long.MinValue && idNumber <= long.MaxValue)
                    {
                        currentNumber = idNumber;
                    }
                }
            }



            Console.WriteLine($"{currentNumber}");
        }
    }
}
