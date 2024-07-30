using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager_Design
{
    internal class AuthService
    {
        private const string CorrectPassword = "cacaseca";

        public bool Authenticate(string password)
        {
            //logica 
            return password == CorrectPassword;
        }
    }
}
