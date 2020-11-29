using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsApp.Models.School
{
    public class TeacherCreator
    {
        public TeacherCreator()
        {

        }
        public void Create(int TeacherID,string TeacherName)
        {
            Teacher teacher = new Teacher() 
            {
                TeacherID=TeacherID,
                TeacherName=TeacherName,
            };
        }
    }
}
