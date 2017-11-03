using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([$]{6,10})|([@]{6,10})|([#]{6,10})|([\^]{6,10})";
            string[] input = Console.ReadLine()
                .Split(new string[] {",","\t"," "}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                string ticket = input[i];
                if (ticket.Length == 20)
                {
                    string leftHalf = ticket.Substring(0, (ticket.Length / 2));
                    string rightHalf = ticket.Substring((ticket.Length / 2), ticket.Length / 2);
                    if (Regex.IsMatch(leftHalf, pattern) && Regex.IsMatch(rightHalf, pattern) &&
                        Regex.Match(leftHalf, pattern).Value.First().ToString() == Regex.Match(rightHalf, pattern).Value.First().ToString())
                    {
                        int length = Math.Min(Regex.Match(leftHalf, pattern).Value.Length, Regex.Match(rightHalf, pattern).Value.Length);
                        string symbol = Regex.Match(leftHalf, pattern).Value.First().ToString();
                        if (length >= 6 && length <= 9)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {length}{symbol}");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {length}{symbol} Jackpot!");
                        }
                    }
                    else 
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else 
                {
                    Console.WriteLine($"invalid ticket");
                }
            }
        }
    }
}
