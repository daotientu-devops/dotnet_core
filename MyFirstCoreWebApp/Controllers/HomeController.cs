using Microsoft.AspNetCore.Mvc;
using MyFirstCoreWebApp.Models;
using MyFirstCoreWebApp.Repositories;
using MyFirstCoreWebApp.ViewModels;
using System;
using System.Linq;

namespace MyFirstCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        [Route("Home/Create")]
        public ViewResult Index()
        {
            Student student = new Student
            {
                AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList()
            };
            return View(student);
        }

        [Route("About")]
        public string About()
        {
            return "About() Action Method of HomeController";
        }

        public JsonResult GetStudentDetails(int Id)
        {
            TestStudentRepository repository = new TestStudentRepository();
            Student studentDetails = repository.GetStudentById(Id);
            return Json(studentDetails);
        }

        public ViewResult Detail()
        {
            //Student Basic Detail
            Student student = new Student()
            {
                StudentId = 110,
                Name = "Dillip",
                Branch = Branch.CSE,
                Section = "A",
                Gender = Gender.Male
            };
            //Student Address
            Address address = new Address()
            {
                StudentId = 111,
                City = "Mumbai",
                State = "Maharashtra",
                Country = "India",
                Pin = "400097"
            };
            //Creating the View model
            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                Title = "Student Detail Page",
                Header = "Student Detail",           
            };
            // Pass the studentDetailsViewModel to the view
            return View(studentDetailsViewModel);
        }

        [Route("Home/Details/{id?}")]
        public ViewResult Details(int id)
        {
            //String string Data
            ViewData["Title"] = "Student Details Page";
            ViewData["Header"] = "Student Details";
            Student student = new Student()
            {
                StudentId = id,
                Name = "James",
                Branch = Branch.CSE,
                Section = "A",
                Gender = Gender.Male
            };
            // Storing Student Data
            ViewData["Student"] = student;
            return View();
        }
    }
}
