using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IReturnBookService
    {
        List<ReturnBook> GetAll();
        ReturnBook GetById(int id);
        void Add(ReturnBook returnBook);
        void Update(ReturnBook returnBook);
        void Delete(IssueBook issueBook);
        List<ReturnBookDetailsDto> GetReturnBookDetails();

    }
}
