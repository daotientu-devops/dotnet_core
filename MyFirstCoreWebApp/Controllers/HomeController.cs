using Microsoft.AspNetCore.Mvc;
using MyFirstCoreWebApp.Models;
using MyFirstCoreWebApp.Repositories;

namespace MyFirstCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is Index action from MVC Controller";
        }

        public JsonResult GetStudentDetails(int Id)
        {
            TestStudentRepository repository = new TestStudentRepository();
            Student studentDetails = repository.GetStudentById(Id);
            return Json(studentDetails);
        }
    }
}
