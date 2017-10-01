using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_The_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            sbyte numberOfIds = sbyte.Parse(Console.ReadLine());
            long currentNumber = long.MinValue;
            double sentance = 1;
            if (numeralType == "sbyte")
            {
                for (int i = 0; i < numberOfIds; i++)
                {
                    long idNumber = long.Parse(Console.ReadLine());

                    if (idNumber >= currentNumber && idNumber >= sbyte.MinValue && idNumber <= sbyte.MaxValue)
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

            if (currentNumber >= sbyte.MaxValue)
            {
                sentance = Math.Ceiling((double)currentNumber / 127);
            }
            else if (currentNumber <= sbyte.MinValue)
            {
                sentance = Math.Ceiling((double)currentNumber / -128);
            }

            if (sentance > 1)
            {
                Console.WriteLine($"Prisoner with id {currentNumber} is sentenced to {sentance} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {currentNumber} is sentenced to {sentance} year");
            }

            
        }
    }
}
