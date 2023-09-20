using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskListWinf
{
    enum Roles
    {
        Administrator,
        User,
        Director
    }
    internal class User
    {
        private string name;
        private int password;
        private Roles role;
        public string Name { get { return name; } }
        public int Password { get { return password; } }
        public Roles Role { get { return role; } set { role = value; } }
        public User(string name, int password, Roles role = Roles.User)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
    }
}
