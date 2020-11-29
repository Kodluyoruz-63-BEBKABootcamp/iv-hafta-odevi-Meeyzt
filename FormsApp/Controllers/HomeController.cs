using FormsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using FormsApp.Models.DomaninModels;
using System;

namespace FormsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Data dt = new Data();
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            initValues init = new initValues();
            init.GetValues();
            return View();
        }

        private void initValues()
        {
            throw new NotImplementedException();
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
