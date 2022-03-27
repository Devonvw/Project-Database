using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

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
        public List<User> GetUsers()
        {
            try
            {
                List<User> users = userdb.GetAllUsers();
                return users;
            }
            catch (Exception)
            {
                // iets ging er mis met database verbinding, dus maak een nep student aan een list zodat we zeker weten dat de applicatie doorblijft werkt
                List<User> users = new List<User>();
                User u = new User();
                u.UserName = "Pieter";
                u.PassWord = "Welom01";
                users.Add(u);

                return users;
            }
        }
        public void AddUser(User user)
        {
            userdb.AddUser(user);
        }
    }
}
