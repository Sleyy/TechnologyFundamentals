using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "A")
                {
                    phonebook[command[1]] = command[2];
                }
                else if (command[0] == "S")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"{command[1]} -> {phonebook[command[1]]}");

                    }
                    else
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                    }
                }
                else if (command[0] == "ListAll")
                {
                    foreach (var pair in phonebook)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.val}");
                    }
                }
                else if (command[0] == "END")
                {
                    break;
                }
            }
        }
    }
}
