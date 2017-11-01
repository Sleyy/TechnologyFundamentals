using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada
{
    class Soldiers
    {
        public int Activity { get; set; }
        public string SoldierName { get; set; }
        public int SoldierCount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int soldierLines = int.Parse(Console.ReadLine());
            Dictionary<string,Soldiers> legions = new Dictionary<string, Soldiers>();

            string[] input = Console.ReadLine()
                .Split(new string[] {" ", "=", "-", ">", ":"}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input.Length > 2)
            {
                Soldiers currentSoldiers = new Soldiers();
                currentSoldiers.Activity = int.Parse(input[0]);
                currentSoldiers.SoldierName = input[2];
                currentSoldiers.SoldierCount = int.Parse(input[3]);
                if (!legions.ContainsKey(input[1]))
                {
                    legions.Add(input[1],currentSoldiers);
                }
                else
                {
                    
                }





                input = Console.ReadLine()
                    .Split(new string[] { " ", "=", "-", ">", ":" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
        }
    }
}
