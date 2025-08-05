using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part02Question02
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Roles { get; set; }

        public User(string username, string password, Role roles)
        {
            Username = username;
            Password = password;
            Roles = roles;
        }
    }
}
