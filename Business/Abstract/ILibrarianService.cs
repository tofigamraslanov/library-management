using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ILibrarianService
    {
        List<Librarian> GetAll();
        Librarian GetById(int id);
        void Add(Librarian librarian);
        void Update(Librarian librarian);
        void Delete(Librarian librarian);
    }
}