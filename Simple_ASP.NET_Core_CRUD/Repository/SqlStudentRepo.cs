using Microsoft.EntityFrameworkCore;
using Simple_ASP.NET_Core_CRUD.DataAccessLayer;
using Simple_ASP.NET_Core_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_ASP.NET_Core_CRUD.Repository
{
    public class SqlStudentRepo : IStudentRepo
    {
        private readonly StudentContext _context;

        public SqlStudentRepo(StudentContext context)
        {
            _context = context;
        }
        public void DeleteStudent(int Id)
        {
            Student studentToDelete = _context.Students.Find(Id);
            if (studentToDelete!=null)
            {
                _context.Students.Remove(studentToDelete);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.Include("Gender").ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.Include("Gender").FirstOrDefault(x => x.StudentId == id);
        }

        public void InsertStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
