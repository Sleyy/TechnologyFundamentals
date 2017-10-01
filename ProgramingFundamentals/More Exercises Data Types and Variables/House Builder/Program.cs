using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOne = int.Parse(Console.ReadLine());
            long numberTwo = int.Parse(Console.ReadLine());
            long price = 0;
            if (numberOne >= sbyte.MinValue && numberOne <= sbyte.MaxValue)
            {
                price += numberOne * 4;
            }
            else 
            {
                price += numberOne * 10;
            }
            if (numberTwo >= sbyte.MinValue && numberTwo <= sbyte.MaxValue)
            {
                price += numberTwo * 4;
            }

            else  
            {
                price += numberTwo * 10;
            }

            Console.WriteLine(price);
        }
    }
}
