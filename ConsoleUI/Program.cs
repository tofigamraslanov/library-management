using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            LibrarianManager librarianManager = new LibrarianManager(new EfLibrarianDal());
            StudentManager studentManager = new StudentManager(new EfStudentDal());
            var result = studentManager.GetAll();
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
    }
}
