using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement = Console.ReadLine();
            bool thisStatement = Convert.ToBoolean(statement);

            if (thisStatement == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
