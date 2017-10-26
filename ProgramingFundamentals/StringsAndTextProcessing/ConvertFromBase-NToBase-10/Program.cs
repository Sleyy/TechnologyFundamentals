using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase_NToBase_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            int number = int.Parse(input[0]);
            string binary = input[1];
            BigInteger result = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                BigInteger temp = BigInteger.Parse(binary.Substring(binary.Length - i-1, 1));
                result += BigInteger.Multiply(temp,BigInteger.Pow(new BigInteger(number),i));


            }



            Console.WriteLine(result);
        }
    }
}
