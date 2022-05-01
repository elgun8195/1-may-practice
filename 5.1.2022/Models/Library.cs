using System;
using System.Collections.Generic;
using System.Text;

namespace _5._1._2022.Models
{
    class Library
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        List<Book> _books = new List<Book>();
        public Library()
        {
            Id = ++_id;
        }


        public void AddBook(Book book)
        {
            if (book == null)
            {
                throw new NullReferenceException();
            }
            _books.Add(book);
        }

        public void ShowAllBooks()
        {
            foreach (Book item in _books)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.AuthorName} - {item.BookCode}");
            }
        }

        public Book FindBookById(int? id)
        {

            if (_books.Exists(x => x.Id == id))
            {
                return _books.Find(e => e.Id == id);
            }
            return null;
        }

        public Book FindBookByBookCode(string code)
        {
            if (code == null)
            {
                throw new NullReferenceException();
            }
            _books.Exists(x => x.BookCode == code);
            return _books.Find(e => e.BookCode == code);
        }
    }
}
