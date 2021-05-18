using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ReturnBookManager : IReturnBookService
    {
        private IReturnBookDal _returnBookDal;
        private IIssueBookService _issueBookService;

        public ReturnBookManager(IReturnBookDal returnBookDal)
        {
            _returnBookDal = returnBookDal;
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
