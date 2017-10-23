using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBooks = int.Parse(File.ReadAllLines("input1.txt").First());


            Library library = new Library();
            List<Book> books = new List<Book>();
            string[] input = File.ReadAllText("input1.txt")
                .Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            File.Delete("result1.txt");
            DateTime date = new DateTime();
            for (int i = 1; i <= numberOfBooks; i++)
            {
                string[] currentInput = input[i]
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Book book = new Book();
                book.Title = currentInput[0];
                book.Author = currentInput[1];
                book.Publisher = currentInput[2];
                book.ReleaseDate = DateTime.ParseExact(currentInput[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.Isbn = int.Parse(currentInput[4]);
                book.Price = double.Parse(currentInput[5]);
                books.Add(book);
            }
            DateTime givenDate = DateTime.ParseExact(input[numberOfBooks+1], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            library.books = books;



            foreach (var boook in library.books.OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {
                if (boook.ReleaseDate > givenDate)
                {
                    File.AppendAllText("result1.txt",$"{boook.Title} -> {boook.ReleaseDate:dd.MM.yyyy} {Environment.NewLine}");
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