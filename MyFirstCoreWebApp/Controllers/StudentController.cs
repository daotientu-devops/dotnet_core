using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCoreWebApp.Controllers
{
    public class StudentController
    {
        public string GetStudentsByName(string name)
        {
            return $"Return All Students with Name: {name}";
        }
    }
}
