﻿using System;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
<<<<<<< HEAD
using System.Collections.Generic;
=======
>>>>>>> 17d58020577860b952d86b38e34d41bc414a866c
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
<<<<<<< HEAD
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
=======
        public string GetSecretQuestion(string userName)
        {
            string query = "select secretQuestion from Users where userName = @userName";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
               new SqlParameter("@userName", SqlDbType.VarChar) { Value = userName },
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            if (dataTable != null)
            {
                if (dataTable.Rows.Count == 0)
                {
                    throw new InvalidOperationException($"This account does not exist or has no secret question.");
                }
            }

            string secretQuestion = (string)dataTable.Rows[0]["secretQuestion"];

            return secretQuestion;
        }

        public bool ValidateSecretAnswer(string userName, string secretAnswer)
        {
            string query = "SELECT CASE WHEN EXISTS (SELECT* FROM Users WHERE Users.userName = @userName and Users.secretAnswer = @secretAnswer) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END as valid";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                    new SqlParameter("@userName", SqlDbType.VarChar) { Value = userName },
                    new SqlParameter("@secretAnswer", SqlDbType.VarChar) { Value = secretAnswer },
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            bool validUser = (bool)dataTable.Rows[0]["valid"];

            return validUser;
        }
        public void ChangePassword(string userName, string newPassWord)
        {
            string query = "exec dbo.usp_forgotChangePassword @userName=@userName, @passWord=@newPassword";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                    new SqlParameter("@userName", SqlDbType.VarChar) { Value = userName },
                    new SqlParameter("@newPassword", SqlDbType.VarChar) { Value = newPassWord },
            };

            ExecuteEditQuery(query, sqlParameters);
        }

>>>>>>> 17d58020577860b952d86b38e34d41bc414a866c
    }
}

