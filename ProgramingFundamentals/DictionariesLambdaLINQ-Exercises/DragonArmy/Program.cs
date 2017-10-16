using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragons = new Dictionary<string, SortedDictionary<string, Dictionary<int, Dictionary<int, int>>>>();
            
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
                var num1 = int.TryParse(input[2],out dragonDmg);
                if (num1==false)
                {
                    dragonDmg = 45;
                }
                var num2 = int.TryParse(input[3],out dragonHealth);
                if (num2 == false)
                {
                    dragonHealth = 250;
                }
                var num3 = int.TryParse(input[4],out dragonArmor);
                if (num3 == false)
                {
                    dragonArmor = 10;
                }
                if (!dragons.ContainsKey(dragonType))
                {
                    dragons.Add(dragonType,new SortedDictionary<string, Dictionary<int, Dictionary<int, int>>>());
                }
                if (!dragons[dragonType].ContainsKey(dragonName))
                {
                    dragons[dragonType].Add(dragonName,new Dictionary<int, Dictionary<int, int>>());
                    dragons[dragonType][dragonName].Add(dragonDmg,new Dictionary<int, int>());
                    dragons[dragonType][dragonName][dragonDmg].Add(dragonHealth,dragonArmor);
                  
                }
                else
                {
                    dragons[dragonType][dragonName].Add(dragonDmg, new Dictionary<int, int>());
                    dragons[dragonType][dragonName][dragonDmg].Add(dragonHealth, dragonArmor);
                 
                }
            }
            foreach (var dragonType in dragons)
            {
                Console.WriteLine($"{dragonType.Key}::{dragonType.Value.Values.Select(x=>x.Keys)}");
                foreach (var dragonName in dragonType.Value)
                {
                    foreach (var dragonDmg in dragonName.Value)
                    {
                        foreach (var dragonHpAndArmor in dragonDmg.Value)
                        {
                            
                            Console.WriteLine($"{dragonName.Key} -> damage: {dragonDmg.Key}, health: {dragonHpAndArmor.Key}, armor: {dragonHpAndArmor.Value}");
                        }
                    }
                }
            }
        }
    }
}
