using System;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
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

    }
}

