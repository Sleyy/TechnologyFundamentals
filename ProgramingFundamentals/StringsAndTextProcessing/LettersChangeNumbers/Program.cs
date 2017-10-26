using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new string[] {" ","\t"}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            double sum = 0;
          
            for (int i = 0; i < input.Length; i++)
            {
                double number = double.Parse(input[i].Substring(1, input[i].Length - 2));
                
                   
                    if (char.IsUpper(input[i].First()))
                    {
                        number = number / (input[i].First() - 64);
                    }
                    else if (char.IsLower(input[i].First()))
                    {
                        number = number * (input[i].First() - 96);
                    }
                    if (char.IsUpper(input[i].Last()))
                    {
                        number = number - (input[i].Last() - 64);
                    }
                    else if (char.IsLower(input[i].Last()))
                    {
                        number = number + (input[i].Last() - 96);
                    }
                
                sum += number;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }

}
