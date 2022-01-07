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
            List<Student> listStudents = new List<Student>()
            {
                new Student() {StudentId = 101, Name="James",Branch="CSE", Section="A", Gender="Male"},
                new Student() {StudentId = 102, Name="Smith",Branch="ETC", Section="B", Gender="Male"},
                new Student() {StudentId = 103, Name="David",Branch="CSE", Section="A", Gender="Male"},
                new Student() {StudentId = 104, Name="Sara",Branch="CSE", Section="A", Gender="Female"},
                new Student() {StudentId = 105, Name="Pam",Branch="ETC", Section="B", Gender="Female"},
            };
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
