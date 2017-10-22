using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int entities = int.Parse(Console.ReadLine());
            Dictionary<string, double> items = new Dictionary<string, double>();
            for (int i = 0; i < entities; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new String[] { "-" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (!items.ContainsKey(input[0]))
                {
                    items.Add(input[0], double.Parse(input[1]));
                }
                else
                {
                    items[input[0]] = double.Parse(input[1]);
                }
            }

            string[] command = Console.ReadLine()
                .Split(new string[] { "-", "," }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<Customer> allCustomers = new List<Customer>();

            while (command[0] != "end of clients")
            {

                Customer currentCostumer = new Customer();
                currentCostumer.BoughtProducts = new Dictionary<string, double>();


                if (items.ContainsKey(command[1]))
                {
                    currentCostumer.Name = command[0];
                    if (!currentCostumer.BoughtProducts.ContainsKey(command[1]))
                    {
                        currentCostumer.BoughtProducts.Add(command[1], double.Parse(command[2]));
                    }
                    else
                    {
                        currentCostumer.BoughtProducts[command[1]] += double.Parse(command[2]);
                    }
                }
                if (allCustomers.Any(x => x.Name == currentCostumer.Name))
                {
                    Customer existingCustomer = allCustomers.First(x => x.Name == currentCostumer.Name);
                    if (existingCustomer.BoughtProducts.ContainsKey(command[1]))
                    {
                        existingCustomer.BoughtProducts[command[1]] += double.Parse(command[2]);
                    }
                    else
                    {
                        existingCustomer.BoughtProducts[command[1]] = double.Parse(command[2]);
                    }
                }
                else
                {
                    allCustomers.Add(currentCostumer);
                }
                command = Console.ReadLine()
            .Split(new string[] { "-", "," }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
            }

            foreach (var customer in allCustomers)
            {
                foreach (var item in customer.BoughtProducts)
                {

                    foreach (var product in items)
                    {
                        if (item.Key == product.Key) { customer.Bill += item.Value * product.Value; }
                    }
                }
            }
            var ordered = allCustomers
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Bill)
                .ToList();
            foreach (var customer in ordered)
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, double> item in customer.BoughtProducts)
                {


                    Console.WriteLine($"-- {item.Key} - {item.Value}");


                }
                if (customer.Bill != 0)
                {
                    Console.WriteLine("Bill: {0:f2}", customer.Bill);
                }
                

            }
            Console.WriteLine("Total bill: {0:F2}", allCustomers.Sum(c => c.Bill));
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, double> BoughtProducts { get; set; }
        public double Bill { get; set; }
    }
}
