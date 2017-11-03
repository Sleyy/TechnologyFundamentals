using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Files
{
    class Files
    {
        public string name { get; set; }
        public string extension { get; set; }
        public long size { get; set; }
    }

    class ResultFiles
    {
        public string name { get; set; }
        public string extension { get; set; }
        public long size { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int numberOfFiles = int.Parse(Console.ReadLine());
            Dictionary<string,Dictionary<string, List<Files>>> filesList = new Dictionary<string, Dictionary<string,List<Files>>>();
            string pattern = @"^([^\\]+)\\(.*\\?)\\:?(.*\..*\;[0-9]+)$";
            string filesPattern = @"(.*)\.(.*)\;(.*)";
            
            for (int i = 0; i < numberOfFiles; i++)
            {
                try
                {

                
                string input = Console.ReadLine();
                MatchCollection matches = Regex.Matches(input, pattern);
                MatchCollection fileMatches = Regex.Matches(matches[0].Groups[3].Value, filesPattern);
                string root = matches[0].Groups[1].Value;
                string folder = matches[0].Groups[2].Value;
                string fileName = fileMatches[0].Groups[1].Value;
                string extension = fileMatches[0].Groups[2].Value;
                Files currentFile = new Files();
                currentFile.name = fileName;
                currentFile.extension = extension;
                currentFile.size = long.Parse(fileMatches[0].Groups[3].Value);
                
                if (!filesList.ContainsKey(root))
                {
                    filesList.Add(root,new Dictionary<string, List<Files>>());
                    filesList[root].Add(folder,new List<Files>());
                    filesList[root][folder].Add(currentFile);
                    
                }

                
                else if (filesList[root].ContainsKey(folder))
                {
                    if (filesList[root][folder][0].name.Contains(fileName) && filesList[root][folder][0].extension.Contains(extension))
                    {
                        filesList[root][folder][0].size = long.Parse(fileMatches[0].Groups[3].Value);
                    }
                    else
                    {
                        filesList[root][folder].Add(currentFile);
                    }
                   
                }
                else if (filesList.ContainsKey(root))
                {
                    filesList[root].Add(folder, new List<Files>());
                    filesList[root][folder].Add(currentFile);

                }
                }
                catch (Exception ex)
                {

                }

            }
            string[] command = Regex.Split(Console.ReadLine()," in ")
                .ToArray();
            string findExtension = command[0];
            string findRoot = command[1];
            bool isFound = false;
            List<ResultFiles> resultList = new List<ResultFiles>();
            foreach (var file in filesList)
            {
                
                if (file.Key == findRoot)
                {
                    foreach (var element in file.Value.Values)
                    {
                        if (element[0].extension == findExtension)
                        {
                            ResultFiles resultFiles = new ResultFiles();
                            
                           
                            resultFiles.name = element[0].name;
                            resultFiles.extension = element[0].extension;
                            resultFiles.size = element[0].size;
                            resultList.Add(resultFiles);
                            isFound = true;
                        }
                    }
                }
            }
            if (!isFound )
            {
                Console.WriteLine("No");
            }
            else
            {
                resultList = resultList.OrderByDescending(x => x.size).ThenBy(x => x.name).ToList();
                foreach (var result in resultList)
                {
                    Console.WriteLine($"{result.name}.{result.extension} - {result.size} KB");
                }
            }
            
            

        }
    }
}
