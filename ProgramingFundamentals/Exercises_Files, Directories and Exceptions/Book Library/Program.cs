using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBooks = int.Parse(File.ReadAllLines("input1.txt").First());


            Library library = new Library();
            List<Book> books = new List<Book>();
            string[] input = File.ReadAllText("input1.txt")
                .Split(new string[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            File.Delete("result1.txt");
            for (int i = 1; i <= numberOfBooks; i++)
            {
                string[] currentInput = input[i]
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Book book = new Book();
                book.Title = currentInput[0];
                book.Author = currentInput[1];
                book.Publisher = currentInput[2];
                book.ReleaseDate = currentInput[3];
                book.Isbn = int.Parse(currentInput[4]);
                book.Price = double.Parse(currentInput[5]);
                books.Add(book);
            }
            library.books = books;
            var filteredBookes = library.books.Select(b => new
                {
                    Author = b.Author,
                    EarningsTotal = library.books
                        .Where(y => y.Author.Equals(b.Author))
                        .Sum(y => y.Price)
                }).Distinct()
                .OrderByDescending(x => x.EarningsTotal)
                .ThenBy(y => y.Author).ToList();

            foreach (var boook in filteredBookes)
            {
                File.AppendAllText("result1.txt",$"{boook.Author} -> {boook.EarningsTotal:f2} {Environment.NewLine}");
            }
        }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> books { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public int Isbn { get; set; }
        public double Price { get; set; }
    }
}
