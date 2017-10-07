using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace InstructionSet
{
    class Program
    {
        static void Main()
        {
            BigInteger result = 0;
            while (true)
            {
                string opCode = Console.ReadLine();
                string[] codeArgs = opCode.Split(' ');


                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                            operandOne++;
                            result = operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                            operandOne--;
                            result = operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                            BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                            BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                            result = (operandOne * operandTwo);
                            break;
                        }
                    case "END":
                        {
                            return;
                        }
                }
                Console.WriteLine(result);
            }
        }
    }
}
