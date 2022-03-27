using System;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System.Collections.Generic;

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
            string query = $"INSERT INTO Users ( userID, userName, passWord, salt, adminstatus ) VALUES ( '{user.UserId}', '{user.UserName}', '{user.PassWord}', '{user.PassWord}', '{user.Salt}', '{user.AdminStatus}')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
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
                string salt = (String)dr["salt"];
                string adminStatus = (String)dr["adminStatus"];

                User user = new User(userID, userName, password, salt, adminStatus);
                users.Add(user);
            }
            return users;
        }
    }
}

