using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new string[] {",", " ", "\t"}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> demons = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                string currentDemon = input[i];
                string healthPattern = @"[^0-9+\-*\/.]+";
                int health = 0;
                string healthString = string.Empty;
                MatchCollection matches = Regex.Matches(currentDemon, healthPattern);
                foreach (Match match in matches)
                {
                    healthString += match.Value;
                }
                var healthChars = healthString.ToCharArray();
                foreach (var ch in healthChars)
                {
                    health += ch;
                }
                string damagePattern = @"(-?[0.0-9.9]+)";
                double damage = 0;
                MatchCollection matched = Regex.Matches(currentDemon, damagePattern);
                foreach (Match number in matched)
                {
                    double currentNumber = 0;
                    if (number.Value.StartsWith("-"))
                    {
                        currentNumber = double.Parse(number.Value.TrimStart('-').ToString());
                        damage -= currentNumber;
                    }
                    else
                    {
                        currentNumber = double.Parse(number.Value);
                        damage += currentNumber;
                    }
                }
                string symbols = @"(\*|\/)";
                MatchCollection matchedSymbols = Regex.Matches(currentDemon, symbols);
                foreach (Match symbol in matchedSymbols)
                {
                    if (symbol.Value == "*")
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                demons.Add($"{currentDemon} - {health} health, {damage:f2} damage");
            }
            demons = demons.OrderBy(x => x).ToList();
            foreach (var demon in demons)
            {
                Console.WriteLine(demon);
            }
        }
    }
}
