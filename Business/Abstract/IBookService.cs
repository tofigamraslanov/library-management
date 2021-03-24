using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book GetById(int id);
        List<Book> GetByQuantity(Expression<Func<Book, bool>> filter);
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
    }
}