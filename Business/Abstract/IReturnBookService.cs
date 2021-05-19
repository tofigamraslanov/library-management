using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IReturnBookService
    {
        List<ReturnBook> GetAll();
        ReturnBook GetById(int id);
        List<ReturnBookDetailsDto> GetByStudentName(string studentName);
        List<ReturnBookDetailsDto> GetByBookName(string bookName);
        void Add(ReturnBook returnBook);
        void Update(ReturnBook returnBook);
        List<ReturnBookDetailsDto> GetReturnBookDetails();

    }
}
