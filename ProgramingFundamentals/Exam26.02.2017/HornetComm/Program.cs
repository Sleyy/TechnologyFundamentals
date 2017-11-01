using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetComm
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
                
            string messagePattern = @"^(\d+) \<\-\> ([a-zA-Z0-9]+)$";
            string broadcastPattern = @"^(\D+) \<\-\> ([a-zA-Z0-9]+)$";
            

            List<string> broadcasts = new List<string>();
            List<string> messages = new List<string>();
            while (input != "Hornet is Green")
            {
                if (Regex.IsMatch(input, messagePattern))
                {

                    Match match = Regex.Match(input,messagePattern);
                    string code = match.Groups[1].Value;
                    string message = match.Groups[2].Value;
                    string reversedCode = string.Empty;
                    for (int i = code.Length - 1; i >= 0; i--)
                    {
                        reversedCode += code[i];
                    }
                    messages.Add(reversedCode + " -> " +message);


                }
                else if (Regex.IsMatch(input, broadcastPattern))
                {
                    Match match = Regex.Match(input, broadcastPattern);
                    StringBuilder frequency = new StringBuilder(match.Groups[2].Value);
                    string message = match.Groups[1].Value;

                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (frequency[i] <= 122 && frequency[i] >= 97)
                        {
                            
                            frequency[i] -= (char)32;

                        }
                        else if (frequency[i] <= 90 && frequency[i] >= 65)
                        {

                            frequency[i] += (char)32;

                        }
                    }
                    
                    broadcasts.Add(frequency + " -> "+message);
                }
                else
                {
                    input = Console.ReadLine();
                    continue;

                }



                input = Console.ReadLine();

            }
            Console.WriteLine($"Broadcasts:");
            if (broadcasts.Count != 0)
            {
                foreach (var br in broadcasts)
                {
                    Console.WriteLine($"{br}");
                }
            }
            else
            {
                Console.WriteLine($"None");
            }
            
            Console.WriteLine($"Messages:");
            if (messages.Count != 0)
            {
                foreach (var mes in messages)
                {
                    Console.WriteLine($"{mes}");
                }
            }
            else
            {
                Console.WriteLine($"None");
            }
            
        }
    }
}
