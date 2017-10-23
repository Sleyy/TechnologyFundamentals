using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstFile = File.ReadAllLines("input1.txt");
            string[] secondFile = File.ReadAllLines("input2.txt");
            File.Delete("result.txt");
            SortedList<string,string> result = new SortedList<string,string>();

            foreach (var file in firstFile)
            {
                result.Add(file,null);
            }
            foreach (var file in secondFile)
            {
                result.Add(file, null);
            }
            foreach (var item in result.Keys)
            {
                File.AppendAllText("result.txt", item+Environment.NewLine);
            }
            
        }

    }
}
