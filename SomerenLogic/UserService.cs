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
        public string GetSecretQuestion(string userName)
        {
            return userdb.GetSecretQuestion(userName);
        }
        public void ChangeForgotPassword(string userName, string secretAnswer, string newPassword)
        {
            if (userdb.ValidateSecretAnswer(userName, secretAnswer))
            {
                userdb.ChangePassword(userName, newPassword);
            }
            else
            {
                throw new Exception("This is not the correct answer!");
            }
        }
    }
}
