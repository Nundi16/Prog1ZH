using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1ZHXml
{
    public class Book
    {
        public Book(string id, string title,string category, double? price, DateTime publishDate, Author author,string description)
        {
            Id = id;
            Category = category;
            Price = price;
            PublishDate = publishDate;
            Author = author;
            Description = description;
        }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime PublishDate { get; set; }
        public double? Price { get; set; }
        public Author Author { get; set; }
        public string Description { get; set; }

        public static List<Book> Feed()
        {
            var _result = new List<Book>();
            /*First Book*/
            _result.Add(new Book("bk101", "XML Developer's Guide", "Computer"
                , 44.95, DateTime.Parse("2000-10-01T00:00:00"), new Author("Gambardella", "Matthew",DateTime.Parse("2000-10-01T00:00:00")), "An in-depth look at creating applications with XML.");

            return _result;

        }
    }
    public class Author
    {
        public Author(string firstName,string lastName,DateTime birthDate)
        {
            FirstName = firstName;
            LastName = LastName;
            BirthDate = birthDate;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
