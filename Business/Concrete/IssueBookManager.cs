using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class IssueBookManager : IIssueBookService
    {
        readonly IIssueBookDal _issueBookDal;
        private readonly IBookService _bookService;

        public IssueBookManager(IIssueBookDal issueBookDal, IBookService bookService)
        {
            _issueBookDal = issueBookDal;
            _bookService = bookService;
        }

        public List<IssueBookDetailsDto> GetIssueBookDetails()
        {
            return _issueBookDal.GetIssueBookDetails();
        }

        public List<IssueBookDetailsDto> GetByStudentName(string studentName)
        {
            return _issueBookDal.GetIssueBookDetails().Where(c => c.StudentName.ToLower().Contains(studentName.ToLower())).ToList();
        }

        public List<IssueBookDetailsDto> GetByBookName(string bookName)
        {
            return _issueBookDal.GetIssueBookDetails().Where(c => c.BookName.ToLower().Contains(bookName.ToLower())).ToList();

        }

        public void Add(IssueBook issueBook)
        {
            _issueBookDal.Add(issueBook);
            var book = _bookService.GetAll().SingleOrDefault(i => i.Id == issueBook.BookId);
            if (book != null)
            {
                book.Quantity--;
                _bookService.Update(book);
            }
        }

        public void Delete(IssueBook issueBook)
        {
            _issueBookDal.Delete(issueBook);
            var books = _bookService.GetAll();
            if (books.Count > 0)
            {
                var book = books.SingleOrDefault(i => i.Id == issueBook.BookId);
                if (book != null)
                {
                    book.Quantity++;
                    _bookService.Update(book);
                }
            }
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
            var book = _bookService.GetAll().SingleOrDefault(i => i.Id == issueBook.BookId);
            if (book != null)
            {
                book.Quantity--;
                _bookService.Update(book);
            }
        } 
    }
}
