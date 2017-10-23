using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] lines =  File.ReadAllLines(@"input.txt");
            File.Delete("result.txt");
            for (int i = 1; i < lines.Length; i+=2)
            {
                
                File.AppendAllText("result.txt",lines[i]+Environment.NewLine);
            }
        }
    }
}
