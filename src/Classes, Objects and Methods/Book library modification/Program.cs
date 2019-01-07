using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_21_Book_library_modification
{

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public static Book Parse(string input)
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
            DateTime afterDate = new DateTime();
            for (int i = 0; i <= n; i++)
            {
                if (i == n)
                {
                   afterDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
                }
                else
                {
                    var book = Book.Parse(Console.ReadLine());
                    library.BookList.Add(book);
                } 
            }

            var chosenTitles = new List<Book>();

            foreach (var book in library.BookList)
            {
                if (book.ReleaseDate > afterDate)
                {
                    chosenTitles.Add(book);
                }
            }

            var orderedTitles = chosenTitles.OrderBy(x => x.ReleaseDate).ThenBy(y => y.Title).ToList();

            foreach (var book in orderedTitles)
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            }
        }
    }
}
