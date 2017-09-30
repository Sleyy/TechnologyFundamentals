using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte centuries = sbyte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = (long)(hours * 60);
            ulong seconds = (ulong)(minutes * 60);
            ulong milliSeconds = seconds * 1000;
            decimal microSeconds = milliSeconds * 1000;
            decimal nanoSeconds =microSeconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} " +
                $"minutes = {seconds} seconds = {milliSeconds} milliseconds = {microSeconds} microseconds = {nanoSeconds} nanoseconds");

        }
    }
}
