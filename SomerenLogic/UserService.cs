using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;

namespace SomerenLogic
{
    public class UserService
    {
        UserDao userdb;

        public UserService()
        {
            userdb = new UserDao();
        }
        public bool ValidUser(string userName, string Password)
        {
            return userdb.ValidUser(userName, Password);
        }
        public string GetStatus(string status)
        {
            return userdb.GetStatus(status);
        }
    }
}
