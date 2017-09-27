
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace character_Stats
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHp = int.Parse(Console.ReadLine());
            var maxHp = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());



            Console.WriteLine($"Name: {name}");

            Console.Write("Health: ");
            Console.Write("|");
            Console.Write(new string('|',currentHp));
            Console.Write(new string('.', maxHp  - currentHp));
            Console.WriteLine("|");

            Console.Write("Energy: ");
            Console.Write("|");
            Console.Write(new string('|', currentEnergy));
            Console.Write(new string('.', maxEnergy  - currentEnergy));
            Console.WriteLine("|");




        }
    }
}
