using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSales = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[numberOfSales];
            for (int i = 0; i < numberOfSales; i++)
            {
                sales[i] = ReadSale();
            }
            var towns = sales.Select(s => s.Town).Distinct().OrderBy(t => t);

            foreach (var town in towns)
            {
                var salesByTown = sales.Where(s => s.Town == town).Select(s => s.Price * s.Quantity);
                Console.WriteLine("{0} -> {1:f2}", town, salesByTown.Sum());
            }
        }

        public class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }



        }

        static Sale ReadSale()
        {
            string[] input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            return new Sale()
            {
                Town = input[0],
                Product = input[1],
                Price = decimal.Parse(input[2]),
                Quantity = decimal.Parse(input[3])
            };
        }



    }






}
