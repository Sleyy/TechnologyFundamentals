using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber >= 1 && dayNumber <=7)
            {
                Console.WriteLine(dayOfWeek[dayNumber-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }

        }
    }
}
