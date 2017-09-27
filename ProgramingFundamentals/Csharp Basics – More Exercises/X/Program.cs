using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int topSideSpace = 0;
            int topMidSpace = n - 2;

            for (int i = 1; i <= (n/2); i++)
            {
                Console.Write(new string(' ', topSideSpace));
                Console.Write("x");
                Console.Write(new string(' ', topMidSpace));
                Console.Write("x");
                Console.WriteLine(new string(' ',topSideSpace));
                topSideSpace++;
                topMidSpace -= 2;
            }
            Console.Write(new string(' ',(n/2)));
            Console.Write("x");
            Console.WriteLine(new string(' ', (n / 2) - 1));

            topSideSpace--;
            topMidSpace += 2;
            for (int i = 1; i <= (n / 2); i++)
            {

                Console.Write(new string(' ', topSideSpace));
                Console.Write("x");
                Console.Write(new string(' ', topMidSpace));
                Console.Write("x");
                Console.WriteLine(new string(' ', topSideSpace));
                topSideSpace--;
                topMidSpace += 2;
            }



        }
    }
}
