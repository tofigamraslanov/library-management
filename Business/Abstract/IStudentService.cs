using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetById(int id);
        void Add(Student student);
        void Update(Student student);
        void Delete(Student student);
    }
}