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
            StudentManager _studentManager = new StudentManager(new EfStudentDal());
            var result = _studentManager.GetAll().FindAll(p => p.Id != 0);
            foreach (var item in result)
            {
                Console.WriteLine(item.Id);
            }
            Console.ReadLine();
        }
    }
}
