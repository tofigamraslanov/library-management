using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class LibrarianManager : ILibrarianService
    {
        private ILibrarianDal _librarianDal;

        public LibrarianManager(ILibrarianDal librarianDal)
        {
            _librarianDal = librarianDal;
        }

        public List<Librarian> GetAll()
        {
            return _librarianDal.GetAll();
        }

        public Librarian GetById(int id)
        {
            return _librarianDal.Get(l => l.Id == id);
        }

        public void Add(Librarian librarian)
        {
            _librarianDal.Add(librarian);
        }

        public void Update(Librarian librarian)
        {
            _librarianDal.Update(librarian);
        }

        public void Delete(Librarian librarian)
        {
            _librarianDal.Delete(librarian);
        }
    }
}