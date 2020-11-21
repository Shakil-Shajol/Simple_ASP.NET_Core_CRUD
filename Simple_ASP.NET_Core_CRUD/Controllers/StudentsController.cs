using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Simple_ASP.NET_Core_CRUD.Models;
using Simple_ASP.NET_Core_CRUD.Repository;

namespace Simple_ASP.NET_Core_CRUD.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentRepo _repo;
        private readonly IGenderRepo _genderRepo;

        public StudentsController(IStudentRepo repo,IGenderRepo genderRepo)
        {
            _repo = repo;
            _genderRepo = genderRepo;
        }
        public IActionResult Index()
        {
            List<Student> students = _repo.GetAllStudents().ToList();
            return View(students);
        }


        public IActionResult Details(int id)
        {
            Student student = _repo.GetStudentById(id);
            if (student==null)
            {
                return NotFound();
            }
            return View(student);
        }

        public IActionResult Edit(int id)
        {
            List<Gender> genders = _genderRepo.GetAllGenders().ToList();
            ViewBag.Genders = new SelectList(genders.ToList(), "GenderId", "Sex");//for gender Dropdown
            Student student = _repo.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateStudent(student);
                return RedirectToAction("Details", new { id = student.StudentId });
            }
            List<Gender> genders = _genderRepo.GetAllGenders().ToList();
            ViewBag.Genders = new SelectList(genders.ToList(), "GenderId", "Sex");//for gender Dropdown
            return View(student);
        }
        public IActionResult Create()
        {
            List<Gender> genders = _genderRepo.GetAllGenders().ToList();
            ViewBag.Genders = new SelectList(genders.ToList(), "GenderId", "Sex");//for gender Dropdown
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _repo.InsertStudent(student);
                return RedirectToAction("Details", new { id = student.StudentId });
            }
            List<Gender> genders = _genderRepo.GetAllGenders().ToList();
            ViewBag.Genders = new SelectList(genders.ToList(), "GenderId", "Sex");//for gender Dropdown
            return View(student);
        }
        public IActionResult Delete(int id)
        {
            _repo.DeleteStudent(id);
            return RedirectToAction("Index");
        }


    }
}
