using FormsApp.Models.School;
using FormsApp.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsApp.Models.DomaninModels
{
    public class Data
    {
        public Data()
        {
            users = new List<User>();
            teachers = new List<Teacher>();
            lessons = new List<Lesson>();
            students = new List<Student>();
        }
        public List<User> users { get; set; }
        public List<Teacher> teachers { get; set; }
        public List<Lesson> lessons{ get; set; }
        public List<Student> students{ get; set; }
    }
}
