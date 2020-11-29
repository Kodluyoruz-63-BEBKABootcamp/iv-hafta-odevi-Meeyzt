using FormsApp.Models.UserModels;
using Microsoft.AspNetCore.Mvc;
using FormsApp.Models.DomaninModels;
using FormsApp.Models;
using System;

namespace FormsApp.Controllers
{    
    public class UserController : Controller
    {
        Data dt = new Data();
        public IActionResult Register()
        {
            initValues init = new initValues();
            init.GetValues();
            return View();
        }

        [HttpPost]
        public IActionResult Register(string username, string password)
        {
            int id = dt.users.Count - 1;

            //UserCreation
            var x = new User() { UserID = id, Username = username, Password = password };
            dt.users.Add(x);
            return Content("Congralations Register Successfull \n ID = " + x.UserID + " Username = " + x.Username + " Password = " + x.Password);
        }
        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            int x = 0;
            foreach (var item in dt.users)
            {
                if(username==item.Username && password==item.Password)
                {
                    x = 1; 
                    break;
                }
            }
            if (x==0)
            {
                return Content("Not found");
            }else
            {
                return Content("Congralations Login Successfull\n Hoşgeldin " + username);
            }
        }
    }
}
