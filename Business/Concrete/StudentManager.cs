using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        public Student GetById(int id)
        {
            return _studentDal.Get(s => s.Id == id);
        }

        public List<Student> GetByName(string name)
        {
            return _studentDal.GetAll(s => s.Name.ToLower().Contains(name.ToLower()));
        }

        public List<Student> GetByDepartment(string department)
        {
            return _studentDal.GetAll(s => s.Department.ToLower().Contains(department.ToLower()));
        }

        public List<Student> GetByCourse(int course)
        {
            return _studentDal.GetAll(s => s.Course == course);
        }

        public void Add(Student student)
        {
            _studentDal.Add(student);
        }

        public void Update(Student student)
        {
            _studentDal.Update(student);
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }
    }
}