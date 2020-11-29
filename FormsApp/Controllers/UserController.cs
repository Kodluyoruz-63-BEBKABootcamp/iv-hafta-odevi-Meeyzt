using FormsApp.Models.UserModels;
using Microsoft.AspNetCore.Mvc;

namespace FormsApp.Controllers
{    
    public class UserController : Controller
    {
        User users = new User();
        UserCreator userCreator = new UserCreator();

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(string username, string password)
        {
            //UserCreation
            var Trumpet = userCreator.Create(1, username, password);
            return Content("Congralations Register Successfull \n ID = " + Trumpet.UserID + " Username = " + Trumpet.Username + " Password = " + Trumpet.Password);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if(username == "Trumpet" && password=="MAGA2023")
            {
                return Content(username + " Hoşgeldin");
            }else if (username == "KivancTTug" && password == "Kivancgutiltat")
            {
                return Content(username + " Hoşgeldin");
            }
            else if (username == "B.MertYagci" && password == "Nisa2020")
            {
                return Content(username + " Hoşgeldin");
            }
            else
            {
                return Content("Not FOUND");
            }
        }
    }
}
