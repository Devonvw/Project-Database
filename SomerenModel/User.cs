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
        public string Salt;
        public string AdminStatus;
        public User()
        {
        }

        public User(int userId, string userName, string passWord, string salt, string adminStatus)
        {
            UserId = userId;
            UserName = userName;
            PassWord = passWord;
            Salt = salt;
            AdminStatus = adminStatus;
        }
    }
}
