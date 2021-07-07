namespace FormsApp.Models.School
{
    public class Lesson
    {
        public Lesson()
        {

        }
        public int LessonID { get; set; }
        public string LessonName { get; set; }
        public Teacher Teacher { get; set; }
    }
}
