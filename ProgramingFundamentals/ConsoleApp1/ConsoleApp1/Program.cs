using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            DateTime examTime = DateTime.ParseExact($"{examHour}:{examMinutes}", "H:m", null);
            DateTime arriveTime = DateTime.ParseExact($"{arriveHour}:{arriveMinutes}", "H:m", null);


            var time = examTime - arriveTime;

            int hours = Math.Abs(time.Hours);


        }
    }
}
