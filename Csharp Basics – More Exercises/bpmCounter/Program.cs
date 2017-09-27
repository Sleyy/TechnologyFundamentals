using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bpmCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            double bpm = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());

            double bars = numberOfBeats / 4;
            double lengthSeconds = numberOfBeats / bpm * 60;

            if (lengthSeconds >= 60)
            {
                Console.WriteLine($"{Math.Round(bars, 1)} bars - {Math.Floor(lengthSeconds / 60)}m {Math.Floor(lengthSeconds % 60)}s");
            }
            else
            {
                Console.WriteLine($"{Math.Round(bars, 1)} bars - 0m {Math.Floor(lengthSeconds % 60)}s");
            }
           
            
            
        }
    }
}
