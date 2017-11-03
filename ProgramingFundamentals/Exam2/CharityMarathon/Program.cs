using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonDays = int.Parse(Console.ReadLine());
            int numberOfRunners = int.Parse(Console.ReadLine());
            int averageNumberOfLaps = int.Parse(Console.ReadLine());
            int tracklength = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal donationPerKm = decimal.Parse(Console.ReadLine());

            int runnerCapacity = Math.Min(numberOfRunners,(trackCapacity * marathonDays));
            BigInteger totalMeters = (BigInteger)runnerCapacity * averageNumberOfLaps * tracklength;
            decimal totalKm = (decimal)totalMeters / 1000;
            decimal totalDonation = donationPerKm * totalKm;

            Console.WriteLine($"Money raised: {totalDonation:f2}");

        }
    }
}
