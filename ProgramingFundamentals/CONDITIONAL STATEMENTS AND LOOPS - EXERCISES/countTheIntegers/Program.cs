using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (true)
            {
                var data = Console.ReadLine();
                int dataParse;
               
                if (!int.TryParse(data, out dataParse))
                {
                    break; 
                }
                counter++;

            }

            Console.WriteLine(counter);
            

        }
    }
}
