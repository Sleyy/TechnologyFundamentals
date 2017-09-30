using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Characters_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string uniName = Console.ReadLine();
            char farewellOne = char.Parse(Console.ReadLine());
            char farewellTwo = char.Parse(Console.ReadLine());
            char farewellThree = char.Parse(Console.ReadLine());
            string mood = Console.ReadLine();

            Console.WriteLine(uniName);
            Console.WriteLine(farewellOne);
            Console.WriteLine(farewellTwo);
            Console.WriteLine(farewellThree);
            Console.WriteLine(mood);
        }
    }
}
