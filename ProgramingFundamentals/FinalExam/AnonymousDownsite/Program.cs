using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWebsitesDown = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal totalLoss = 0;
            List<string> websites = new List<string>();
            BigInteger securityToken = securityKey;
            for (int i = 0; i < numberOfWebsitesDown-1; i++)
            {
                securityToken *= securityKey;
            }
            for (int i = 0; i < numberOfWebsitesDown; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] {" ", "\t"}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string siteName = input[0];
                decimal siteVisits = decimal.Parse(input[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(input[2]);
                websites.Add(siteName);
                 totalLoss += siteVisits * siteCommercialPricePerVisit;
            }
            Console.WriteLine(string.Join("\r\n",websites));
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
