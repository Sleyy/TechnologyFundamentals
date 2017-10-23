using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(File.ReadAllText("input1.txt"));
            Random rnd = new Random();
            File.Delete("result.txt");
            string[] phrases =
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };
            string[] events =
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
            string[] authors =
                {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] cities =
                {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};


            for (int i = 0; i < numberOfMessages; i++)
            {
                File.AppendAllText("result.txt",phrases[rnd.Next(0, phrases.Length)]+" ");
                File.AppendAllText("result.txt", events[rnd.Next(0, events.Length)]+" ");
                File.AppendAllText("result.txt", authors[rnd.Next(0, authors.Length)]+" - ");
                File.AppendAllText("result.txt", cities[rnd.Next(0, cities.Length)] + Environment.NewLine);
            }
        }
    }
}
