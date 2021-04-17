using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetById(int id);
        List<Student> GetByName(string name);
        List<Student> GetByDepartment(string department);
        List<Student> GetByCourse(int course);
        void Add(Student student);
        void Update(Student student);
        void Delete(Student student);
    }
}