using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada
{
   
   
    class Program
    {
        static void Main(string[] args)
        {
            int soldierLines = int.Parse(Console.ReadLine());
            Dictionary<string,Dictionary<string,long>> legions = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string,int> legionActivity = new Dictionary<string, int>();
            
            for (int i = 0; i < soldierLines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ', '=','-', '>',':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int activity = int.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                long soldierCount = long.Parse(input[3]);
                if (!legions.ContainsKey(legionName))
                {
                    legions.Add(legionName, new Dictionary<string, long>());
                    legions[legionName].Add(soldierType,soldierCount);
                    legionActivity.Add(legionName, activity);
                }
                else if (legions.ContainsKey(legionName))
                {
                    if (legionActivity[legionName] <= activity)
                    {
                        legionActivity[legionName] = activity;
                    }
                    if (!legions[legionName].ContainsKey(soldierType))
                    {
                        legions[legionName].Add(soldierType, soldierCount);
                    }
                    else
                    {
                        legions[legionName][soldierType] += soldierCount;
                    }
                }
            }
            string[] printCommand = Console.ReadLine()
                .Split(new string[] {"\\"}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            if (printCommand.Length==2)
            {
                legions = legions.Where(x => x.Value.ContainsKey(printCommand[1])).OrderByDescending(x => x.Value[printCommand[1]]).ToDictionary(x=>x.Key,x=>x.Value);
                foreach (var legion in legions)
                {
                    if (legionActivity[legion.Key] < int.Parse(printCommand[0]))
                    {
                        foreach (var solderGroup in legion.Value)
                        {
                            if (solderGroup.Key == printCommand[1])
                            {
                                Console.WriteLine($"{legion.Key} -> {solderGroup.Value}");
                            }
                        }
                    }
                }
            }
            else
            {
                legionActivity = legionActivity.OrderByDescending(x => x.Value).ToDictionary(x=> x.Key,x=> x.Value);
                foreach (var legion in legionActivity)
                {
                    if (legions[legion.Key].Keys.Contains(printCommand[0]))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }
        }
    }
}
