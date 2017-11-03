using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] songsAvailable = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            string[] command = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var awarded = new Dictionary<string, List<string>>();
            while (command[0] != "dawn")
            {
                string name = command[0];
                string song = command[1].TrimStart(' ');
                string award = command[2].TrimStart(' ');
                if (participants.Contains(name) && songsAvailable.Contains(song))
                {
                    if (!awarded.ContainsKey(name))
                    {
                        awarded.Add(name, new List<string>());
                        awarded[name].Add(award);

                    }
                    else if (awarded.ContainsKey(name) && !awarded[name].Contains(award))
                    {

                        awarded[name].Add(award);
                    }
                }

                command = Console.ReadLine()
                    .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            }
            awarded = awarded.Distinct().OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);
            if (awarded.Count > 0)
            {
                foreach (var singer in awarded)
                {
                    Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");
                    foreach (var award in singer.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award.ToString()}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"No awards");
            }
            
        }
    }
}
