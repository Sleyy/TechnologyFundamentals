using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugIndexes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] field = new int[fieldSize];
            for (int i = 0; i < fieldSize; i++)
            {
                if (ladybugIndexes.Contains(i))
                {
                    field[i] = 1;
                }

            }



            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "end")
                {
                    break;
                }
                int ladybugIndex = int.Parse(command[0]);
                string direction = command[1];
                int moves = int.Parse(command[2]);
                if (moves < 0)
                {
                    moves = Math.Abs(moves);
                    if (direction == "right")
                    {
                        direction = "left";
                    }
                    else
                    {
                        direction = "right";
                    }
                }
                int rightLandingPosition = moves + ladybugIndex;
                int leftLandingPosition = ladybugIndex - moves;
                bool hasLanded = false;
                if (ladybugIndex > field.Length - 1 || ladybugIndex < 0 || field[ladybugIndex] == 0)
                {
                    continue;
                }

                while (!hasLanded)
                {
                    field[ladybugIndex] = 0;
                    if (direction == "right")
                    {
                        if (rightLandingPosition > field.Length - 1)
                        {
                            break;
                        }
                        if (field[rightLandingPosition] == 1)
                        {
                            rightLandingPosition += moves;
                        }
                        else if (field[rightLandingPosition] == 0)
                        {
                            field[rightLandingPosition] = 1;
                            hasLanded = true;
                        }
                    }
                    else if (direction == "left")
                    {
                        if (leftLandingPosition < 0)
                        {
                            break;
                        }
                        if (field[leftLandingPosition] == 1)
                        {
                            leftLandingPosition -= moves;
                        }
                        else if (field[leftLandingPosition] == 0)
                        {
                            field[leftLandingPosition] = 1;
                            hasLanded = true;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));

        }
    }
}
