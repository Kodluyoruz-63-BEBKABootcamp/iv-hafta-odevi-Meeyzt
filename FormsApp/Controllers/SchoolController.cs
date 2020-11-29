using FormsApp.Models;
using FormsApp.Models.DomaninModels;
using Microsoft.AspNetCore.Mvc;

namespace FormsApp.Controllers
{
    public class SchoolController : Controller
    {
        Data dt = new Data();
        public IActionResult StudentRegistiration()
        {
            initValues init = new initValues();
            init.GetValues();
            ViewBag.lessons = dt.lessons;
            ViewBag.teachers = dt.teachers;
            return View();
        }
    }
}
