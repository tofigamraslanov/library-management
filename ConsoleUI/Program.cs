using Business.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager(new EfBookDal());
            StudentManager studentManager = new StudentManager(new EfStudentDal());
            LibrarianManager librarianManager = new LibrarianManager(new EfLibrarianDal());

            foreach (var book in librarianManager.GetAll())
            {
                Console.WriteLine(book.Name);
            }

            Console.ReadLine();
        }
    }
}
