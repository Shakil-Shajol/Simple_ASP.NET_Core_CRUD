using Simple_ASP.NET_Core_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_ASP.NET_Core_CRUD.Repository
{
    public interface IStudentRepo
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        void InsertStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int Id);
    }
}
