using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.DTOs;

namespace Business.Concrete
{
    public class IssueBookManager : IIssueBookService
    {
        IIssueBookDal _issueBookDal;
        private IBookService _bookService;
        public IssueBookManager(IIssueBookDal issueBookDal, IBookService bookService)
        {
            _issueBookDal = issueBookDal;
            _bookService = bookService;
        }

        public List<IssueBookDetailsDto> GetIssueBookDetails()
        {
            return _issueBookDal.GetIssueBookDetails();
        }

        public void Add(IssueBook issueBook)
        {
            _issueBookDal.Add(issueBook);
            var book = _bookService.GetAll().SingleOrDefault(i => i.Id == issueBook.BookId);
            book.Quantity--;
            _bookService.Update(book);
        }

        public void Delete(IssueBook issueBook)
        {
            _issueBookDal.Delete(issueBook);
            //var books = _bookService.GetAll();
            //if (books.Count > 0)
            //{
            //    var book = books.SingleOrDefault(i => i.Id == issueBook.BookId);
            //    if (book.Quantity > 0)
            //    {
            //        book.Quantity++;
            //        _bookService.Update(book);
            //    }
            //}
        }

        public List<IssueBook> GetAll()
        {
            return _issueBookDal.GetAll();
        }

        public IssueBook GetById(int id)
        {
            return _issueBookDal.Get(ib => ib.Id == id);
        }

        public void Update(IssueBook issueBook)
        {
            _issueBookDal.Update(issueBook);
        }
    }
}
