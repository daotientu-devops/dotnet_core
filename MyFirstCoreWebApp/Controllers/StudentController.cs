using Microsoft.AspNetCore.Mvc;
using MyFirstCoreWebApp.Models;
using MyFirstCoreWebApp.Repositories;
using System.Collections.Generic;

namespace MyFirstCoreWebApp.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Index()
        {
            TestStudentRepository repository = new TestStudentRepository();
            List<Student> listStudents = repository.GetAllStudents();           
            return View(listStudents);
        }
        public ViewResult Detail(int Id)
        {
            TestStudentRepository repository = new TestStudentRepository();
            Student studentDetail = repository.GetStudentById(Id); 
            return View(studentDetail);
        }

        public string GetStudentsByName(string name)
        {
            return $"Return All Students with Name: {name}";
        }
    }
}
