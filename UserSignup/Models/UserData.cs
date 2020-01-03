using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class UserData
    {
        public static List<User> users = new List<User>();

        public static List<User> GetAll()
        {
            return users;
        }
        public static void Add(User newUser)
        {
            users.Add(newUser);
        }
        public static User GetById(int id)
        {
            return users.Single(p => p.UserId == id);
        }
    }
}
