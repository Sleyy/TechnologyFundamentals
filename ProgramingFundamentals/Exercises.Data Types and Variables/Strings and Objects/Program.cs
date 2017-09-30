using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            object tempObject = firstWord + " " + secondWord;
            string sentance = Convert.ToString(tempObject);

            Console.WriteLine(sentance);
        }
    }
}
