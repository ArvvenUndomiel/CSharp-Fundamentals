using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_20_Book_Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate {get; set;}
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public static Book Parse (string input)
        {
            var args = input.Split(' ').ToList();
            Book book = new Book();
            book.Title = args[0];
            book.Author = args[1];
            book.Publisher = args[2];
            book.ReleaseDate = DateTime.ParseExact(args[3], "dd.MM.yyyy", null);
            book.ISBN = args[4];
            book.Price = decimal.Parse(args[5]);

            return book;
        }
    }

    class Library
    {
        public Library()
        {
            BookList = new List<Book>();
        }
        public string Name { get; set; }
        public List<Book> BookList { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Library library = new Library();
            for (int i = 0; i < n; i++)
            {
                var book = Book.Parse(Console.ReadLine());
                library.BookList.Add(book);
            }

            var groupedAuthors = library.BookList
                .GroupBy(x => x.Author)
                .OrderByDescending(x => x.Sum(y => y.Price))
                .ThenBy(x => x.First().Author);
                

            // Each Group = key => new List<book>() 
            
            foreach (var book in groupedAuthors)
            {
                var totalSum = book.Sum(x => x.Price);

                Console.WriteLine($"{book.Key} -> {totalSum:f2}");
            }
        }
    }
}
