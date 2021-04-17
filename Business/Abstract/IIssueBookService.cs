using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IIssueBookService
    {
        List<IssueBook> GetAll();
        IssueBook GetById(int id);
        List<IssueBookDetailsDto> GetIssueBookDetails();
        List<IssueBookDetailsDto> GetByStudentName(string studentName);
        List<IssueBookDetailsDto> GetByBookName(string bookName);
        void Add(IssueBook issueBook);
        void Update(IssueBook issueBook);
        void Delete(IssueBook issueBook);
    }
}
