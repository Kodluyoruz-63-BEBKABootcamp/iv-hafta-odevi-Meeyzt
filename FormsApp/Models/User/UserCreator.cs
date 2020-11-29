using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsApp.Models.User
{
    public class UserCreator
    {
        public UserCreator()
        {

        }
        public User Create(int userID, string username,string password)
        {
            User user = new User()
            {
                UserID = userID,
                Username = username,
                Password = password
            };
            return user;
        }
    }
}
