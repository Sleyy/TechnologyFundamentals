using System;
using System.Collections.Generic;
using System.Globalization;
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
            DateTime date = new DateTime();
            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Book book = new Book();
                book.Title = input[0];
                book.Author = input[1];
                book.Publisher = input[2];
                book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.Isbn = int.Parse(input[4]);
                book.Price = double.Parse(input[5]);
                books.Add(book);
            }
            DateTime givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            library.books = books;
            
            

            foreach (var boook in library.books.OrderBy(x=>x.ReleaseDate).ThenBy(x=>x.Title))
            {
                if (boook.ReleaseDate > givenDate)
                {
                    Console.WriteLine($"{boook.Title} -> {boook.ReleaseDate:dd.MM.yyyy}");
                }
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
        public DateTime ReleaseDate { get; set; }
        public int Isbn { get; set; }
        public double Price { get; set; }
    }
}
