using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToBooks
{
    class Program
    {
        static BooksDataClassesDataContext context = new BooksDataClassesDataContext();


        public static void AddAuthor(string firstName, string lastName, int yearBorn, int? yearDied = null)
        {
            context.Authors.InsertOnSubmit(new Author() { FirstName = firstName,
                LastName = lastName, YearBorn = yearBorn, YearDied = yearDied });

            context.SubmitChanges();
        }


        public static void AddBook(string title, string description, DateTime datePublished, 
            string publisher, string genre, int pages, string isbn)
        {
            if (isbn.IsNumeric() == false || isbn.Length != 13)
            {
                throw new InvalidOperationException("ISBN should be exactly 13 digits long");
            }
            context.Books.InsertOnSubmit(new Book() { Title = title, Description = description,
                DatePublished = datePublished, Publisher = publisher, Genre = genre, Pages = pages, ISBN = Int32.Parse(isbn) });
        }


        public static void SortBooksByTitle()
        {
            List<Book> Library = new List<Book>();
            foreach (var book in context.Books)
            {
                Library.Add(book);
            }
            List<Book> SortedByTitleList = Library.OrderBy(book => book.Title).ToList();
            foreach (var book in SortedByTitleList)
            {
                Console.WriteLine("Title: {0}, Description: {1}, Date Published: {2}, Publisher: {3}, Genre: {4}, Pages: {5}, ISBN: {6}"
                    , book.Title, book.Description, book.DatePublished, book.Publisher, book.Genre, book.Pages, book.ISBN);
            }
        }

        public static void SortBooksByGenre()
        {
            List<Book> Library = new List<Book>();
            foreach (var book in context.Books)
            {
                Library.Add(book);
            }
            List<Book> SortedByGenreList = Library.OrderBy(book => book.Genre).ToList();
            foreach (var book in SortedByGenreList)
            {
                Console.WriteLine("Title: {0}, Description: {1}, Date Published: {2}, Publisher: {3}, Genre: {4}, Pages: {5}, ISBN: {6}"
                    , book.Title, book.Description, book.DatePublished, book.Publisher, book.Genre, book.Pages, book.ISBN);
            }
        }

        static void Main()
        {
            context.Authors.First().LastName = "Petar";

            context.SubmitChanges();

            var result = from author in context.Authors
            where author.ID > 1
            select new { Name = author.FirstName + author.LastName, Age = DateTime.Today.Year - author.YearBorn };

            foreach (var resultItem in result)
            {
                Console.WriteLine(resultItem.Name + " " + resultItem.Age);
            }

            foreach(var author in context.Authors)
            {
                Console.WriteLine(author.FirstName + " " + author.LastName);
            }
        }
    }

    public static class Extension
    {
        public static bool IsNumeric(this string s)
        {
            long output;
            return long.TryParse(s, out output);
        }
    }
}
