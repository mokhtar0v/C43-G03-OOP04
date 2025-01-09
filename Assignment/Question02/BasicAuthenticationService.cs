using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question02
{
    class BasicAuthenticationService : IAuthenticationService
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public bool AuthenticateUser(string? username, string? password)
        {
            if (username == UserName && password == Password) return true;
            return false;
        }

        public bool AuthorizeUser(string? username, string? role)
        {
            if(username == UserName && role == Role) return true;
            return false;
        }
    }
}
