using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] files = Directory.GetFiles("TestFolder");
            File.Delete("result.txt");
            double sum = 0;
            
            foreach (var file in files)
            {
                FileInfo fileinfo = new FileInfo(file);
                sum += fileinfo.Length;
            }
            sum = sum / 1024 / 1024;
            File.WriteAllText("result.txt", sum.ToString());
        }
    }
}
