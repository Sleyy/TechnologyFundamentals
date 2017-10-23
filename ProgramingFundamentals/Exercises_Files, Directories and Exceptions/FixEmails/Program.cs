using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string[] input = File.ReadAllLines("input1.txt").ToArray();
            File.Delete("result1.txt");
            for (int i = 0; i < input.Length; i+=2)
            {
                if (input[i]=="stop")
                {
                    break;
                }
                else if (!emails.ContainsKey(input[i]) && !input[i+1].EndsWith("us") && !input[i+1].EndsWith("uk"))
                {
                    emails.Add(input[i],input[i+1]);
                }
                
            }
            foreach (var email in emails)
            {
                File.AppendAllText("result1.txt",email.Key+" -> "+email.Value+Environment.NewLine);
            }
        }
    }
}
