using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.GenericCollections
{
    public enum BookLib {Engineering, MBA, DTEd, Pharmacy }
    public class BookLis
    {
        public string AuthorName { get; set; }
        public string BookName { get; set; }
        public int Price { get; set; }
    }
    public class Books
    {
        public List<BookLis> bookLis = new List<BookLis>();
        public BookLib BookLib;
        public int Id { get; set; }
    }
    class BookLibrary
    {
        static void Main(string[] args)
        {
            List<Books> books = new List<Books>()
            {
                new Books
                {
                    Id=457,
                    BookLib=BookLib.Engineering,
                    bookLis =
                    {
                        new BookLis{ AuthorName="Dick Morley", BookName="plc", Price=2799},
                        new BookLis{ AuthorName="Kevin Collins", BookName="Avinash Malekar", Price=4999},
                    }
                },
                new Books
                {
                    Id=789,
                    BookLib=BookLib.MBA,
                    bookLis =
                    {
                         new BookLis{ AuthorName="Dick Morley", BookName="plc", Price=2799},
                        new BookLis{ AuthorName="Kevin Collins", BookName="Avinash Malekar", Price=4999},
                    }
                }
            };
            foreach (var bs in books)
            {
                Console.WriteLine($"{bs.Id} {bs.BookLib}");
                foreach (var bs1 in bs.bookLis)
                {
                    Console.WriteLine($"\t {bs1.AuthorName} {bs1.BookName} {bs1.Price}");
                }
            }
        }
    }
}
