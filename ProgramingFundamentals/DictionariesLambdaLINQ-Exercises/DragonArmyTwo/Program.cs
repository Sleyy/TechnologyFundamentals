using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArmyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragons = new Dictionary<string, SortedDictionary<string, List<int>>>();

            int numberOfDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfDragons; i++)
            {
                var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string dragonType = input[0];
                string dragonName = input[1];
                int dragonDmg;
                int dragonHealth;
                int dragonArmor;
                var num1 = int.TryParse(input[2], out dragonDmg);
                if (num1 == false)
                {
                    dragonDmg = 45;
                }
                var num2 = int.TryParse(input[3], out dragonHealth);
                if (num2 == false)
                {
                    dragonHealth = 250;
                }
                var num3 = int.TryParse(input[4], out dragonArmor);
                if (num3 == false)
                {
                    dragonArmor = 10;
                }
                if (!dragons.ContainsKey(dragonType))
                {
                    dragons.Add(dragonType, new SortedDictionary<string, List<int>>());
                }
                if (!dragons[dragonType].ContainsKey(dragonName))
                {
                    dragons[dragonType].Add(dragonName, new List<int>());
                    dragons[dragonType][dragonName].Add(dragonDmg);
                    dragons[dragonType][dragonName].Add(dragonHealth);
                    dragons[dragonType][dragonName].Add(dragonArmor);
                }
                else
                {
                    dragons[dragonType][dragonName].Add(dragonDmg);
                    dragons[dragonType][dragonName].Add(dragonHealth);
                    dragons[dragonType][dragonName].Add(dragonArmor);

                }
            }
            foreach (var dragonType in dragons)
            {
                Console.WriteLine($"{dragonType.Key}::({(double)dragonType.Value.Values.Average(x=>x[0]):f2}/{(double)dragonType.Value.Values.Average(x => x[1]):f2}/{(double)dragonType.Value.Values.Average(x => x[2]):f2})");
                foreach (var dragonName in dragonType.Value)
                {
                      Console.WriteLine($"-{dragonName.Key} -> damage: {dragonName.Value[0]}, health: {dragonName.Value[1]}, armor: {dragonName.Value[2]}");
                }
            }
        }
    }
}

