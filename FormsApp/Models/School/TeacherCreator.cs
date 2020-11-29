namespace FormsApp.Models.School
{
    public class TeacherCreator
    {
        public TeacherCreator()
        {

        }
        public Teacher Create(int TeacherID,string TeacherName)
        {
            Teacher teacher = new Teacher() 
            {
                TeacherID=TeacherID,
                TeacherName=TeacherName,
            };
            return teacher;
        }
    }
}
