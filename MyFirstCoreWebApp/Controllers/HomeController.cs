using Microsoft.AspNetCore.Mvc;
using MyFirstCoreWebApp.Models;
using MyFirstCoreWebApp.Repositories;
using System.Collections.Generic;

namespace MyFirstCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            var services = this.HttpContext.RequestServices;
            var _repository = (IStudentRepository)services.GetService(typeof(IStudentRepository));
            List<Student> allStudentDetails = _repository.GetAllStudents();
            return Json(allStudentDetails);
        }

        public JsonResult GetStudentDetails(int Id)
        {
            var services = this.HttpContext.RequestServices;
            var _repository = (IStudentRepository)services.GetService(typeof(IStudentRepository));
            Student studentDetails = _repository.GetStudentById(Id);
            return Json(studentDetails);
        }
    }
}
