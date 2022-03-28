using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class User
    {
        public int UserId;
        public string UserName;
        public string PassWord;
        public string AdminStatus;
        public string SecretQuestion;
        public string SecretAnswer;
        public User()
        {
        }

        public User(int userId, string userName, string passWord, string adminStatus, string secretQuestion, string secretAnswer)
        {
            UserId = userId;
            UserName = userName;
            PassWord = passWord;
            AdminStatus = adminStatus;
            SecretQuestion = secretQuestion;
            SecretAnswer = secretAnswer;
        }
    }
}
