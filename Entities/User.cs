using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User:Entity
    {
        public User(string name,string password,string email)
        {
            this.Name = name;
            this.Password = password;
            this.Email = email;
        }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
