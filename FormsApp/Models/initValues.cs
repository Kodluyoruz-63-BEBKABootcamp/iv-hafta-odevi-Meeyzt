using FormsApp.Models.UserModels;
using Microsoft.AspNetCore.Mvc;
using FormsApp.Controllers;
using FormsApp.Models.DomaninModels;
using FormsApp.Models.School;

namespace FormsApp.Models
{
    public class initValues
    {
       
        public initValues()
        {
        }
        public void GetValues() 
        {
            Data dt = new Data();
            //UserCreation
            User Trumpet = new User() { UserID = 1, Username = "Trumpet", Password = "MAGA2023" };
            User Kivanc = new User() { UserID = 2, Username = "KivancTTug", Password = "Kivancgutiltat" };
            User Baris = new User() { UserID = 3, Username = "B.MertYagci", Password = "Nisa2020" };
            //users To list
            dt.users.Add(Trumpet);
            dt.users.Add(Kivanc);
            dt.users.Add(Baris);

            //Teacher Creation
            var Nurdane = new Teacher() { TeacherID = 1, TeacherName = "Nurdane Yazıcı" };
            var Ahmet = new Teacher() { TeacherID = 2, TeacherName = "Ahmet Kaya" };
            // teachers To list
            dt.teachers.Add(Ahmet);
            dt.teachers.Add(Nurdane);

            //Lesson Creation
            var Matematik = new Lesson() { LessonID = 1, LessonName = "Matematik", Teacher = dt.teachers[0] };
            var Turkce = new Lesson() { LessonID = 2, LessonName = "Türkçe", Teacher = dt.teachers[1] };
            //Lesson To list
            dt.lessons.Add(Matematik);
            dt.lessons.Add(Turkce);

            //Student creation
            var Mehmet = new Student() { StudentID = 1, StudentName = "Mehmet Yılmaz", lessons = dt.lessons[0] };
            var Arda = new Student() { StudentID = 2, StudentName = "Arda Turan", lessons = dt.lessons[1] };
            //Student Tolist
            dt.students.Add(Mehmet);
            dt.students.Add(Arda);
        }


    }
}
