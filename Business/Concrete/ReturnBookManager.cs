using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class ReturnBookManager : IReturnBookService
    {
        private readonly IReturnBookDal _returnBookDal;
        private IIssueBookService _issueBookService;

        public ReturnBookManager(IReturnBookDal returnBookDal, IIssueBookService issueBookService)
        {
            _returnBookDal = returnBookDal;
            _issueBookService = issueBookService;
        }

        public List<ReturnBookDetailsDto> GetByBookName(string bookName)
        {
            return _returnBookDal.GetReturnBookDetails().Where(c => c.BookName.ToLower().Contains(bookName.ToLower())).ToList();
        }

        public void Add(ReturnBook returnBook)
        {
            _returnBookDal.Add(returnBook);
        }


        public void Delete(IssueBook issueBook)
        {
            _issueBookService.Delete(issueBook);
        }

        public List<ReturnBook> GetAll()
        {
            return _returnBookDal.GetAll();
        }

        public ReturnBook GetById(int id)
        {
            return _returnBookDal.Get(rb => rb.Id == id);
        }

        public List<ReturnBookDetailsDto> GetByStudentName(string studentName)
        {
            return _returnBookDal.GetReturnBookDetails().Where(c => c.StudentName.ToLower().Contains(studentName.ToLower())).ToList();
        }

        public List<ReturnBookDetailsDto> GetReturnBookDetails()
        {
            return _returnBookDal.GetReturnBookDetails();
        }

        public void Update(ReturnBook returnBook)
        {
            _returnBookDal.Update(returnBook);
        }
    }
}
