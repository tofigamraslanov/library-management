using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfReturnBookDal : EfEntityRepositoryBase<ReturnBook, LibraryManagementContext>, IReturnBookDal
    {
        public List<ReturnBookDetailsDto> GetReturnBookDetails()
        {
            using (LibraryManagementContext context = new LibraryManagementContext())
            {
                var result = from rb in context.ReturnBooks
                             join b in context.Books
                                 on rb.BookId equals b.Id
                             join s in context.Students
                                 on rb.StudentId equals s.Id
                             select new ReturnBookDetailsDto
                             {
                                 ReturnBookId = rb.Id,
                                 StudentName = s.Name,
                                 BookName = b.Name,
                                 IssueDate = rb.IssueDate,
                                 ReturnDate = rb.ReturnDate,
                                 Fine = rb.Fine
                             };
                return result.ToList();
            }
        }
    }
}
