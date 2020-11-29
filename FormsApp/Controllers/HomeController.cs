using FormsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using FormsApp.Models.User;
using FormsApp.Models.School;

namespace FormsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        StudentCreator student = new StudentCreator();
        LessonCreator lesson = new LessonCreator();
        TeacherCreator teachercre = new TeacherCreator();
        UserCreator userCreator = new UserCreator();
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //UserCreation
            var Trumpet = userCreator.Create(1, "Trumpet", "MAGA2023");
            var Kivanc = userCreator.Create(2, "KivancTTug", "Kivancgutiltat");
            var Baris = userCreator.Create(3, "B.MertYagci", "Nisa2020");
            
            //Students Creation
            var Mehmet =  student.Create(1, "Mehmet Yılmaz", lesson.Create(1, "Matematik", teachercre.Create(1, "Nurdane YAZICI")));
            var Beyto = student.Create(2, "Beytullah Yusen", lesson.Create(2, "Türkçe", teachercre.Create(2, "Ahmet Hamdi TANPINAR")));
            var Ahmet = student.Create(3, "Ahmet Kaydırak", lesson.Create(1, "Matematik", teachercre.Create(1, "Nurdane YAZICI")));
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
