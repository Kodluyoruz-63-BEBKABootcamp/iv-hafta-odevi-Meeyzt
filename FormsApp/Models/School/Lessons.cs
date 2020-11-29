using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsApp.Models.School
{
    public class Lessons
    {
        public int LessonID { get; set; }
        public string LessonName { get; set; }
        public string TeacherName { get; set; }
        public Lessons lessons { get; set; }
    }
}
