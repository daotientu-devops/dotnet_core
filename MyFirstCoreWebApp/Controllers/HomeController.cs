using Microsoft.AspNetCore.Mvc;
using MyFirstCoreWebApp.Models;
using MyFirstCoreWebApp.ViewModels;

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
            //Student Basic Detail
            Student student = new Student()
            {
                StudentId = 110,
                Name = "Dillip",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
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
