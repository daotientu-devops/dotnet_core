using Microsoft.AspNetCore.Mvc;
using MyFirstCoreWebApp.Models;
using MyFirstCoreWebApp.Repositories;
using System.Collections.Generic;

namespace MyFirstCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Test");
        }

        public ViewResult About()
        {
            return View();
        }

        public JsonResult GetStudentDetails(int Id)
        {
            var services = this.HttpContext.RequestServices;
            var _repository = (IStudentRepository)services.GetService(typeof(IStudentRepository));
            Student studentDetails = _repository.GetStudentById(Id);
            return Json(studentDetails);
        }

        public ViewResult Detail()
        {
            //String string Data
            ViewBag.Title = "Student Detail Page";
            ViewBag.Header = "Student Detail";
            Student student = new Student()
            {
                StudentId = 110,
                Name = "James",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };
            return View(student);
        }

        public ViewResult Details()
        {
            //String string Data
            ViewData["Title"] = "Student Details Page";
            ViewData["Header"] = "Student Details";
            Student student = new Student()
            {
                StudentId = 110,
                Name = "James",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };
            // Storing Student Data
            ViewData["Student"] = student;
            return View();
        }
    }
}
