using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Change_Alert
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double treshold = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double difference = GetDifference(price, currentPrice);
                bool isSignificantDifference = GetDifferenceAmount(difference, treshold);
                string message = PrintChange(currentPrice, price, difference, isSignificantDifference);
                Console.WriteLine(message);
                price = currentPrice;
            }
        }

        static string PrintChange(double currentPrice, double price, double difference, bool etherTrueOrFalse)
        {
            string result = "";
            if (difference == 0)
            {
                result = string.Format("NO CHANGE: {0}", currentPrice);
                return result;
            }
            else if (!etherTrueOrFalse)
            {
                result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", price, currentPrice, difference * 100);
                return result;
            }
            else if (etherTrueOrFalse && (difference > 0))
            {
                result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", price, currentPrice, difference * 100);
                return result;
            }
            else if (etherTrueOrFalse &&   (difference < 0))
            {
                result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", price, currentPrice, difference * 100);
                return result;
            }
            
            return result;
        }

        static bool GetDifferenceAmount(double treshold, double difference)
        {
            if (Math.Abs(treshold) >= difference )
            {
                return true;
            }
            
            return false;
            

        }

        static double GetDifference(double price, double currentPrice)
        {
            double result = (currentPrice - price) / price;
            return result;
        }
    }
}
