using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsApp.Models.School
{
    public class LessonCreator
    {
        public LessonCreator()
        {

        }
        public Lesson Create(int LessonID,string LessonName,Teacher teacher)
        {
            Lesson lesson = new Lesson()
            {
                LessonID = LessonID,
                LessonName = LessonName,
                Teacher = teacher
            };
            return lesson;
        }
    }
}
