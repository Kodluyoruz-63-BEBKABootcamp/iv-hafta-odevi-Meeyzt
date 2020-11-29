namespace FormsApp.Models.School
{
    public class StudentCreator
    {
        public StudentCreator()
        {

        }

        public Student Create(int id,string studentName,Lesson lessons)
        {
            Student student = new Student()
            {
                StudentID = id,
                StudentName = studentName,
                lessons = lessons
            };
            return student;
        }
    }
}
