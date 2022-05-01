using _5._1._2022.Exceptions;
using _5._1._2022.Models;
using System;

namespace _5._1._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Book book = new Book("DedeGorgud");
            //book.AuthorName = "Elgun Qocayev";
            //Console.WriteLine(book.BookCode);

            //Book book2 = new Book("Masal");
            //book2.AuthorName = "Yusif";
            //Console.WriteLine(book2.BookCode);

            //Library library = new Library();
            //library.AddBook(book);
            //library.AddBook(book2);
            //Console.WriteLine("====================");
            //library.FindBookById(1).Showinfo();
            //library.FindBookById(2).Showinfo();
            //Console.WriteLine("====================");
            //library.FindBookByBookCode("MA1002").Showinfo();
            //library.FindBookByBookCode("DE1001").Showinfo();
            //Console.WriteLine("====================");
            //library.ShowAllBooks();
            #endregion




            Employee employee1 = new Employee(25, "Elgun Qocayev", 1899);
            



            Department department = new Department("Araz MMC", 18);

            try
            {
                department.AddEmployee(employee1);
            }
            catch (CapacityLimitException )
            {
                throw new CapacityLimitException("Limit Ashildi");
            }
            Console.WriteLine(department[0]);
            
        }
    }
}
