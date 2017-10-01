using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfChars = sbyte.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numberOfChars; i++)
            {
                char charValue = char.Parse(Console.ReadLine());
                
                sum += Convert.ToInt32(charValue); 
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
