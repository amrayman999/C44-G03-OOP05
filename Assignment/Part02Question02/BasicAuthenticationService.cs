using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part02Question02
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        private User _user;

        public BasicAuthenticationService(User user)
        {
            _user = user;
        }

        public bool AuthenticateUser(string username, string password)
        {
            return _user.Username == username && _user.Password == password;
        }

        public bool AuthorizeUser(string username, Role requiredRoles)
        {
            return _user.Username == username && (_user.Roles & requiredRoles) == requiredRoles;
        }
    }
}
