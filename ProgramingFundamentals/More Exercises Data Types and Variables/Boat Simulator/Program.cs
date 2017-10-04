using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoatName = char.Parse(Console.ReadLine());
            char secondBoatName = char.Parse(Console.ReadLine());
            sbyte numberOfMoves = sbyte.Parse(Console.ReadLine());
            sbyte firstBoatMoves = 0;
            sbyte secondBoatMoves = 0;

            for (int i = 1; i <= numberOfMoves; i++)
            {
                string speedOfBoat = Console.ReadLine();

                if (firstBoatMoves < 50 && secondBoatMoves < 50)
                {
                    if (speedOfBoat == "UPGRADE")
                    {
                        firstBoatName += (char)3;
                        secondBoatName += (char)3;
                    }
                    else
                    {
                        if (i % 2 != 0)
                        {
                            firstBoatMoves += (sbyte)speedOfBoat.Length;
                        }
                        else
                        {
                            secondBoatMoves += (sbyte)speedOfBoat.Length;
                        }
                    }
                    if (firstBoatMoves >= 50)
                    {
                        Console.WriteLine($"{firstBoatName}");
                    }
                    else if (secondBoatMoves >= 50)
                    {
                        Console.WriteLine($"{secondBoatName}");
                    }
                }
            }
            if (firstBoatMoves < 50 && secondBoatMoves < 50)
            {
                if (firstBoatMoves > secondBoatMoves)
                {
                    Console.WriteLine(firstBoatName);
                }
                else
                {
                    Console.WriteLine(secondBoatName);
                }
            }
        }
    }
}
