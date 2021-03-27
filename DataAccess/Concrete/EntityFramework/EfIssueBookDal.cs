using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfIssueBookDal : EfEntityRepositoryBase<IssueBook, LibraryManagementContext>, IIssueBookDal
    {
        public List<IssueBookDetailsDto> GetIssueBookDetails()
        {
            using (LibraryManagementContext context = new LibraryManagementContext())
            {
                var result = from ib in context.IssueBooks
                             join b in context.Books
                                 on ib.BookId equals b.Id
                             join s in context.Students
                                 on ib.StudentId equals s.Id
                             select new IssueBookDetailsDto()
                             {
                                 IssueBookId = ib.Id,
                                 StudentName = s.Name,
                                 BookName = b.Name,
                                 IssueDate = ib.IssueDate
                             };
                return result.ToList();
            }
        }
    }
}
