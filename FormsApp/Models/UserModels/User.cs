using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsApp.Models.UserModels
{
    public class User
    {
        public User()
        {

        }
        public int UserID { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
    }
}
