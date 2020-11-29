using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsApp.Models.School
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string Lesson { get; set; }
        public Lessons lessons { get; set; }
    }
}
