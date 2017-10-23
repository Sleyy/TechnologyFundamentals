using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            File.Delete("result.txt");
            for (int i = 1; i <= input.Length; i++)
            {
                File.AppendAllText("result.txt",i+". "+input[i-1]+Environment.NewLine);
            }
            
        }
    }
}
