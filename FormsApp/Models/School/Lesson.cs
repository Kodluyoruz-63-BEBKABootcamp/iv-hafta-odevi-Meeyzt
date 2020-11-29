using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsApp.Models.School
{
    public class Lesson
    {
        public int LessonID { get; set; }
        public string LessonName { get; set; }
        public Teacher Teacher { get; set; }
    }
}
