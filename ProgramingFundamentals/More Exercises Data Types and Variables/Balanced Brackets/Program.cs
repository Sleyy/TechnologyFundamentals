using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfStrings = sbyte.Parse(Console.ReadLine());
            string bracketLog = "";
            sbyte leftBrackets = 0;
            sbyte rightBrackets = 0;
            for (int i = 0; i < numberOfStrings; i++)
            {
                string bracketOrRandom = Console.ReadLine();

                if (bracketOrRandom == "(" || bracketOrRandom == ")")
                {
                    if (bracketOrRandom == "(" && bracketLog.EndsWith("("))
                    {
                        Console.WriteLine($"UNBALANCED");
                        return;
                    }
                    else if (bracketOrRandom == ")" && bracketLog.EndsWith(")"))
                    {
                        Console.WriteLine($"UNBALANCED");
                        return;
                    }
                    bracketLog += bracketOrRandom;

                    if (bracketLog.StartsWith(")"))
                    {
                        Console.WriteLine($"UNBALANCED");
                        break;
                    }
                    
                    if (bracketOrRandom == "(")
                    {
                        leftBrackets += 1;
                    }
                    else if (bracketOrRandom == ")")
                    {
                        rightBrackets += 1;
                    }
                }
            }
            if (leftBrackets - rightBrackets != 0)
            {
                Console.WriteLine($"UNBALANCED");
            }
            else if (leftBrackets == rightBrackets && leftBrackets != 0)
            {
                Console.WriteLine($"BALANCED");
            }
        }
    }
}
