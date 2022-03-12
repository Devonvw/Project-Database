using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class RevenueDao : BaseDao
    {
        public int GetSales(DateTime start, DateTime end)
        {
            string query = "SELECT SUM(OD.amount) as sales FROM Order as O, Drink as D Order_Drink as OD WHERE O.dateTime BETWEEN @start AND @end";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            sqlParameters.Append(new SqlParameter("@start", start));
            sqlParameters.Append(new SqlParameter("@end", end));
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            
            return (int)dataTable.Rows[0]["sales"];
        }
        public double GetTurnover(DateTime start, DateTime end)
        {
            string query = "SELECT SUM(OD.amount * D.price) as turnover FROM Order as O, Drink as D Order_Drink as OD WHERE O.dateTime BETWEEN @start AND @end";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            sqlParameters.Append(new SqlParameter("@start", start));
            sqlParameters.Append(new SqlParameter("@end", end));
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            return (double)dataTable.Rows[0]["turnover"];
        }

        public int GetCustomers(DateTime start, DateTime end)
        {
            string query = "SELECT COUNT(DISTINCT O.studentId) AS customers FROM Order as O, Drink as D Order_Drink as OD WHERE O.dateTime BETWEEN @start AND @end";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            sqlParameters.Append(new SqlParameter("@start", start));
            sqlParameters.Append(new SqlParameter("@end", end));
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            return (int)dataTable.Rows[0]["customers"];
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    Id = (int)dr["roomId"],
                    Capacity = (int)dr["multipleBeds"],
                };
                rooms.Add(room);
            }
            return rooms;
        }
    }

}
