using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC236FinalProject
{
    public class User
    {
        public User(string name, string email, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }

        public User(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        public User(string email)
        {
            this.Email = email;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
