using System;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System.Collections.Generic;
using System.Diagnostics;

namespace SomerenDAL
{
    public class UserDao : BaseDao
    {
        public bool ValidUser(string userName, string passWord)
        {
            string query = "exec dbo.usp_userLogin @userName = @userName, @passWord = @passWord";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                    new SqlParameter("@userName", SqlDbType.VarChar) { Value = userName },
                    new SqlParameter("@passWord", SqlDbType.VarChar) { Value = passWord }
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            int validUser = (int)dataTable.Rows[0]["valid"];

            return validUser == 1;
        }
        public string GetStatus(string userName)
        {
            string query = "select adminStatus from Users where userName = @userName";

            SqlParameter[] sqlParameters = new SqlParameter[]
{
                    new SqlParameter("@userName", SqlDbType.VarChar) { Value = userName },
};

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            string validUser = (string)dataTable.Rows[0]["adminStatus"];

            return validUser;
        }
        public List<User> GetAllUsers()
        {
            string query = "SELECT userID, userName, passWord, salt, adminStatus FROM Users";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddUser(User user)
        {
            Debug.WriteLine(user.UserName);
            Debug.WriteLine(user.PassWord);
            Debug.WriteLine(user.AdminStatus);
            Debug.WriteLine(user.SecretQuestion);
            Debug.WriteLine(user.SecretAnswer);

            string query = $"exec dbo.usp_createUser @userName = @userName, @passWord = @passWord, @adminStatus = @adminStatus, @secretQuestion = @secretQuestion, @secretAnswer = @secretAnswer;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@userName", SqlDbType.VarChar) {Value = user.UserName},
                new SqlParameter("@passWord", SqlDbType.VarChar) {Value = user.PassWord},
                new SqlParameter("@adminStatus", SqlDbType.VarChar) {Value = user.AdminStatus},
                new SqlParameter("@secretQuestion", SqlDbType.VarChar) {Value = user.SecretQuestion},
                new SqlParameter("@secretAnswer", SqlDbType.VarChar) {Value = user.SecretAnswer},
            };
            OpenConnection();
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<User> ReadTables(DataTable dataTable)
        {
            List<User> users = new List<User>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int userID = (int)dr["userID"];
                string userName = (String)dr["userName"];
                string password = (String)dr["passWord"];
                string adminStatus = (String)dr["adminStatus"];
                string secretQuestion = (String)dr["secretQuestion"];
                string secretAnswer = (String)dr["secretAnswer"];

                User user = new User(userID, userName, password, adminStatus, secretQuestion, secretAnswer);
                users.Add(user);
            }
            return users;
        }
    }
}

