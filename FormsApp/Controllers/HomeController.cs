using FormsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using FormsApp.Models.User;

namespace FormsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //UserCreation
            UserCreator userCreator = new UserCreator();
            userCreator.Create(1, "Trumpet", "MAGA2023");
            userCreator.Create(2, "KivancTTug", "Kivancgutiltat");
            userCreator.Create(3, "B.MertYagci", "Nisa2020");


            return View();
        }

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
