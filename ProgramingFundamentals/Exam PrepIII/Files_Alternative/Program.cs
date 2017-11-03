using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Files_Alternative
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFiles = int.Parse(Console.ReadLine());

            List<string> allFiles = new List<string>();
            for (int i = 0; i < numberOfFiles; i++)
            {
                allFiles.Add(Console.ReadLine());
            }

            string[] command = Regex.Split(Console.ReadLine(), " in ");
            string rootFilter = command[1];
            string extensionFilter = command[0];

            var resultList = new Dictionary<string,long>();
            foreach (var file in allFiles)
            {
                var fileParts = file.Split(';');
                long fileSize = long.Parse(fileParts[1]);
                string fileName = fileParts[0];
                string exactRoot = fileName.Split('\\').First();
                string exactFileName = fileName.Split('\\').Last();
                if (exactRoot == rootFilter && fileName.EndsWith(extensionFilter))
                {
                    if (!resultList.ContainsKey(exactFileName))
                    {
                        resultList.Add(exactFileName, fileSize);
                    }
                    else
                    {
                        resultList[exactFileName] = fileSize;
                    }
                    
                }
            }
            resultList = resultList.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            if (resultList.Count == 0)
            {
                Console.WriteLine($"No");
            }
            else
            {
                foreach (var result in resultList)
                {
                    Console.WriteLine($"{result.Key} - {result.Value} KB");
                }
            }
            
        }
    }
}
