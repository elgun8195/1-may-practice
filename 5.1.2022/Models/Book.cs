using System;
using System.Collections.Generic;
using System.Text;

namespace _5._1._2022.Models
{
    class Book
    {
        private static int _id;
        private string _code;
        public int Id { get; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string BookCode { get { return _code; } }

        public Book(string name)
        {
            Name = name;
            Id=++_id;
            _code = Name.Substring(0, 2).ToUpper() +(_id+1000);

        }
        public void Showinfo()
        {
            Console.WriteLine($"{Id} - {Name} - {AuthorName} - {BookCode}");
        }

    }
}
