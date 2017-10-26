using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();


            while (pattern.Length >0)
            {

                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }
                if (text.IndexOf(pattern) >= 0 && text.LastIndexOf(pattern) >= 0 || text.IndexOf(pattern) != text.LastIndexOf(pattern))
                {
                    text = text.Remove(text.LastIndexOf(pattern), pattern.Length);
                    text = text.Remove(text.IndexOf(pattern), pattern.Length);
                    Console.WriteLine("Shaked it.");
                }
                
                
                
                pattern = pattern.Remove(pattern.Length / 2, 1);
                
            }
            Console.WriteLine(text);
        }
    }
}
