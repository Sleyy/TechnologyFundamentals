using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBooks = int.Parse(Console.ReadLine());

            
            Library library = new Library();
            List<Book> books = new List<Book>();
            
            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Book book = new Book();
                book.Title = input[0];
                book.Author = input[1];
                book.Publisher = input[2];
                book.ReleaseDate = input[3];
                book.Isbn = int.Parse(input[4]);
                book.Price = double.Parse(input[5]);
                books.Add(book);
            }
            library.books = books;
           var filteredBookes =  library.books.Select(b => new
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
                Console.WriteLine($"{boook.Author} -> {boook.EarningsTotal:f2}");
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
