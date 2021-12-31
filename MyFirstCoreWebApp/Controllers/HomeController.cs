using Microsoft.AspNetCore.Mvc;
using MyFirstCoreWebApp.Models;
using MyFirstCoreWebApp.Repositories;
using System.Collections.Generic;

namespace MyFirstCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _repository = null;
        public HomeController(IStudentRepository repository)
        {
            _repository = repository;
        }

        public JsonResult Index()
        {
            List<Student> allStudentDetails = _repository.GetAllStudents();
            return Json(allStudentDetails);
        }

        public JsonResult GetStudentDetails(int Id)
        {
            TestStudentRepository repository = new TestStudentRepository();
            Student studentDetails = repository.GetStudentById(Id);
            return Json(studentDetails);
        }
    }
}
