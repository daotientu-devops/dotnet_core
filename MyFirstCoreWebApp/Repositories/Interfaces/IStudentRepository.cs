namespace MyFirstCoreWebApp.Models
{
    public interface IStudentRepository
    {
        Student GetStudentById(int StudentId);
    }
}
