using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СръбскоUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> result = new Dictionary<string, Dictionary<string, long>>();
            var command = Console.ReadLine().Split(new string[] { "@" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (command[0] != "End")
            {
                try
                {
                    if (!command[0].EndsWith(" "))
                    {
                        throw new Exception();
                    }
                    string town = "";
                    var singer = command[0];
                    string[] singerCheck = singer.Split(new string[]{" "},StringSplitOptions.RemoveEmptyEntries).ToArray();
                    
                    string[] townAndTickets = command[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    long ticketsCount = long.Parse(townAndTickets[townAndTickets.Length - 1]);
                    long ticketsPrice = long.Parse(townAndTickets[townAndTickets.Length - 2]);
                    long totalTicketsWorth = ticketsCount * ticketsPrice;
                    for (int i = 0; i < townAndTickets.Length - 2; i++)
                    {
                        if (i == townAndTickets.Length - 3)
                        {
                            town += townAndTickets[i];
                        }
                        else
                        {
                            town += townAndTickets[i] + " ";
                        }
                    }
                    string[] townCheck = town.Split(new string[]{" "},StringSplitOptions.RemoveEmptyEntries).ToArray();
                    
                    if (!result.ContainsKey(town))
                    {
                        result.Add(town, new Dictionary<string, long>());

                    }
                    if (!result[town].ContainsKey(singer))
                    {
                        result[town].Add(singer, totalTicketsWorth);
                    }
                    else
                    {
                        result[town][singer] += totalTicketsWorth;
                    }
                }
                catch (Exception Ex)
                {

                }
                command = Console.ReadLine().Split(new string[] { "@" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var town in result)
            {
                Console.WriteLine($"{town.Key}");
                foreach (var singer in town.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key}-> {singer.Value}");
                }
            }
        }
    }
}
