using MyFirstCoreWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstCoreWebApp.Repositories
{
    public class TestStudentRepository : IStudentRepository
    {
        public List<Student> DataSource()
        {
            return new List<Student>()
            {
                new Student() {StudentId = 101, Name = "James", Branch = Branch.CSE, Section = "A", Gender = Gender.Male},
                new Student() { StudentId = 102, Name = "Smith", Branch = Branch.ETC, Section = "B", Gender = Gender.Male },
                new Student() { StudentId = 103, Name = "David", Branch = Branch.CSE, Section = "A", Gender = Gender.Male },
                new Student() { StudentId = 104, Name = "Sara", Branch = Branch.CSE, Section = "A", Gender = Gender.Female },
                new Student() { StudentId = 105, Name = "Pam", Branch = Branch.ETC, Section = "B", Gender = Gender.Female }
            };
        }

        public Student GetStudentById(int StudentId)
        {
            return DataSource().FirstOrDefault(e => e.StudentId == StudentId);
        }

        public List<Student> GetAllStudents()
        {
            return DataSource();
        }
    }
}
