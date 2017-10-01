using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Boundaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            if (number == "sbyte")
            {
                Console.WriteLine(sbyte.MaxValue);
                Console.WriteLine(sbyte.MinValue);
            }
            else if (number == "byte")
            {
                Console.WriteLine(byte.MaxValue);
                Console.WriteLine(byte.MinValue);
            }
            else if (number == "int")
            {
                Console.WriteLine(int.MaxValue);
                Console.WriteLine(int.MinValue);
            }
            else if (number == "uint")
            {
                Console.WriteLine(uint.MaxValue);
                Console.WriteLine(uint.MinValue);
            }
            else if (number == "long")
            {
                Console.WriteLine(long.MaxValue);
                Console.WriteLine(long.MinValue);
            }
        }
    }
}
