using System;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

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
    }
}

