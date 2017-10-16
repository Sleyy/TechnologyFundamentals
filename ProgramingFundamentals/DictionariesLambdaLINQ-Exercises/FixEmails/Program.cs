using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string name = Console.ReadLine();
            string email = "";

            while (name != "stop")
            {
                email = Console.ReadLine();
                if (!email.ToLower().EndsWith("us") && !email.ToLower().EndsWith("uk"))
                {
                    emails.Add(name, email);
                }
                name = Console.ReadLine();
            }
            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}

