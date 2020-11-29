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
        public void Create(int userID, string username,string password)
        {
            User user = new User()
            {
                UserID = userID,
                Username = username,
                Password = password
            };
        }
    }
}
