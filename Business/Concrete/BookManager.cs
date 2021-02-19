using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public Book GetById(int id)
        {
            return _bookDal.Get(b => b.Id == id);
        }

        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }
    }
}