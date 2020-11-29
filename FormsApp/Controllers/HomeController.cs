using FormsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Collections.Generic;
using FormsApp.Models.UserModels;
using FormsApp.Models.School;

namespace FormsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public List<User> users = new List<User>();
        public List<Student> students = new List<Student>();
        public List<Lesson> lessons = new List<Lesson>();
        public List<Teacher> teachers = new List<Teacher>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //UserCreation
            var Trumpet = new User() { UserID=1, Username="Trumpet",Password="MAGA2023" };
            var Kivanc = new User() { UserID = 2, Username = "KivancTTug", Password = "Kivancgutiltat" };
            var Baris = new User() { UserID = 3, Username = "B.MertYagci", Password = "Nisa2020" };
            //users To list
            users.Add(Trumpet);
            users.Add(Kivanc);
            users.Add(Baris);

            //Teacher Creation
            var Nurdane = new Teacher() { TeacherID = 1, TeacherName = "Nurdane Yazıcı" };
            var Ahmet = new Teacher() { TeacherID = 2, TeacherName = "Ahmet Kaya" };
            // teachers To list
            teachers.Add(Ahmet);
            teachers.Add(Nurdane);

            //Lesson Creation
            var Matematik = new Lesson() { LessonID = 1, LessonName = "Matematik",Teacher=teachers[0] };
            var Turkce = new Lesson() { LessonID = 2, LessonName = "Türkçe", Teacher = teachers[1] };
            //Lesson To list
            lessons.Add(Matematik);
            lessons.Add(Turkce);

            //Student creation
            var Mehmet = new Student() { StudentID = 1, StudentName = "Mehmet Yılmaz", lessons = lessons[0] };
            var Arda = new Student() { StudentID = 2, StudentName = "Arda Turan", lessons = lessons[1] };
            //Student Tolist
            students.Add(Mehmet);
            students.Add(Arda);


            return View();
        }
        //(int studentID,string studentName,int lessonID,string lessonName,int teacherID,string teacherName )
       


        public IActionResult Privacy()
        {
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
