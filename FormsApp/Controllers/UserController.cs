using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormsApp.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace FormsApp.Controllers
{
    public class UserController : Controller
    {
        UserCreator userCreator = new UserCreator();

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User user)
        {
            //UserCreation
            var Trumpet = userCreator.Create(1, user.Username, user.Password);
            ViewData["registed"] = "Congralations Register Successfull \n ID = " + Trumpet.UserID + " Username = " + Trumpet.Username + " Password = " + Trumpet.Password;
            return View(ViewData["registed"]);
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
