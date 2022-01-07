using System.Collections.Generic;

namespace MyFirstCoreWebApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public Branch Branch { get; set; }
        public string Section { get; set; }
        public Gender Gender { get; set; }
        public IEnumerable<Gender> AllGenders { get; set; }
    }
}
