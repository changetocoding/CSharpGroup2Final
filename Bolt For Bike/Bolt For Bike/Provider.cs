using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt_For_Bike
{
    internal class Provider
    {
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int Nin { get; set; }
        public string Password { get; set; }

        public  Provider(string fullname, string username, string email, int nin, string password)
        {
            Fullname = fullname;
            Username = username;
            Email = email;
            Nin = nin;
            Password = password;

        }
        public Provider()
        {

        }
    }
  
}
