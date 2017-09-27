using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = int.Parse(Console.ReadLine());
            double height = int.Parse(Console.ReadLine());

            double megapixels = Math.Round((width * height) / 1000000,1);

            Console.WriteLine($"{width}x{height} => {megapixels}MP");

        }
    }
}
