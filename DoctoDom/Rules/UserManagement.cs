using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctoDom.Models;

namespace DoctoDom.Rules
{
    public class UserManagement
    {

        public bool GetUser(int Id)
        {
            return true;
        }


        public bool GetDoctor()
        {
            return true;
        }


        public bool GetUser(string Nickname, string Password)
        {
            return true;
        }


        public bool NewUser(User user)
        {
            return true;
        }


        public bool UpdateUser(User user)
        {
            return true;
        }


        public bool DeleteUser(User user)
        {
            return true;

        }

    }
}