using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([A-Z]{2})([0-9]{1,2}\.[0-9]{1,2})([A-Za-z]+|[a-z]+)\|";
            Dictionary<string, Weather> forecast = new Dictionary<string, Weather>();
            while (input != "end")
            {
                MatchCollection matchedInput = Regex.Matches(input, pattern);
                if (matchedInput.Count > 0)
                {
                    Weather current = new Weather();
                    string city = matchedInput[0].Groups[1].ToString();
                    current.temperature = double.Parse(matchedInput[0].Groups[2].ToString());
                    current.weatherType = matchedInput[0].Groups[3].ToString();
                    if (!forecast.ContainsKey(city))
                    {
                        forecast.Add(city, current);
                        
                    }
                    else
                    {
                        forecast[city] = current;
                    }
                }





                input = Console.ReadLine();
            }
            var orderedDict = forecast.OrderBy(x => x.Value.temperature);
            foreach (var city in orderedDict)
            {
                Console.WriteLine($"{city.Key} => {city.Value.temperature} => {city.Value.weatherType}");
                
            }
        }
    }

    class Weather
    {
        public double temperature { get; set; }
        public string weatherType { get; set; }
    }
}
