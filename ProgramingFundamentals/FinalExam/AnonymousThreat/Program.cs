    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace AnonymousThreat
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<string> words = Console.ReadLine()
                    .Split(new string[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string[] command = Console.ReadLine()
                    .Split(new string[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                while (command[0] != "3:1")
                {
                    string commandAction = command[0];
                    if (commandAction == "merge")
                    {
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        if (endIndex < 0)
                        {
                            endIndex = 0;

                        }
                        else if (endIndex >= words.Count)
                        {
                            endIndex = words.Count - 1;
                            if (startIndex == endIndex)
                            {
                                startIndex -= 1;
                            }

                        }
                        if (startIndex < 0)
                        {
                            startIndex = 0;
                            if (endIndex == startIndex)
                            {
                                endIndex++;
                            }
                        }

                        else if (startIndex >= words.Count)
                        {
                            startIndex = words.Count - 1;
                        }
                    
                        string tempString = string.Empty;
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            tempString += words[i];
                        }
                        words.RemoveRange(startIndex, endIndex - startIndex + 1);
                        words.Insert(startIndex, tempString);
                    }
                
                    else if (commandAction == "divide") 
                    {
                    
                        int index = int.Parse(command[1]);
                        int partitions = int.Parse(command[2]);

                        string currentString = words[index];
                        List<string> tempWord = new List<string>();
                        int divider = 0;
                        int lastDivider = 0;
                        divider = currentString.Length / partitions;
                        if (divider == 0)
                        {
                            break;
                        }
                        if (currentString.Length % partitions != 0)
                        {
                            lastDivider = currentString.Length % partitions;

                            for (int i = 0; i < currentString.Length;)
                            {
                                if (i + divider + lastDivider >= currentString.Length)
                                {
                                    tempWord.Add(currentString.Substring(i, currentString.Length - i));
                                    i += divider + lastDivider;
                               
                                }
                                else
                                {
                                    tempWord.Add(currentString.Substring(i, divider));
                                    i += divider;
                                }

                            }
                        }
                        else if (currentString.Length % partitions == 0)
                        {
                            for (int i = 0; i < currentString.Length;)
                            {
                                tempWord.Add(currentString.Substring(i, divider));
                                i += divider;

                            }
                        }
                        words.RemoveAt(index);
                        int wordsCount = 0;
                        for (int i = index; i < index + tempWord.Count; i++)
                        {

                            words.Insert(i, tempWord[wordsCount]);
                            wordsCount++;

                        }


                    }


                    command = Console.ReadLine()
                        .Split(new string[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                }
                Console.WriteLine(string.Join(" ", words));
            }
        }
    }
