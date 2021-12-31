using System.Collections.Generic;
namespace MyFirstCoreWebApp.Models
{
    public interface IStudentRepository
    {
        Student GetStudentById(int StudentId);
        List<Student> GetAllStudents();
    }
}
