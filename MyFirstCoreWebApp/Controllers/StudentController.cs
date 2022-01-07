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
                new Student() {StudentId = 101, Name="James",Branch=Branch.CSE, Section="A", Gender=Gender.Male},
                new Student() {StudentId = 102, Name="Smith",Branch=Branch.ETC, Section="B", Gender=Gender.Male},
                new Student() {StudentId = 103, Name="David",Branch=Branch.CSE, Section="A", Gender=Gender.Male},
                new Student() {StudentId = 104, Name="Sara",Branch=Branch.CSE, Section="A", Gender=Gender.Female},
                new Student() {StudentId = 105, Name="Pam",Branch=Branch.ETC, Section="B", Gender=Gender.Female},
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
