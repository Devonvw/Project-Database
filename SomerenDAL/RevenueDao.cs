using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;
using System.Diagnostics;

namespace SomerenDAL
{
    public class RevenueDao : BaseDao
    {
        public int GetSales(DateTime start, DateTime end)
        {
            //Debug.WriteLine($"{start.ToString()}, {end.ToString()}");
            string query = "SELECT SUM(C.amount) as sales FROM Contain as C INNER JOIN Drink as D ON D.drinkId = C.drinkId INNER JOIN [Order] as O ON O.orderId = C.orderId WHERE O.dateTime BETWEEN @start AND @end";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@start", SqlDbType.DateTime) { Value = start },
            new SqlParameter("@end", SqlDbType.DateTime) { Value = end }
            };
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            try
            {
                return (int)dataTable.Rows[0]["sales"];
            }
            catch (Exception)
            {
                throw new InvalidOperationException($"No data found");
            }
        }
        public double GetTurnover(DateTime start, DateTime end)
        {
            string query = "SELECT SUM(C.amount * D.price) as turnover FROM Contain as C INNER JOIN Drink as D ON D.drinkId = C.drinkId INNER JOIN [Order] as O ON O.orderId = C.orderId WHERE O.dateTime BETWEEN @start AND @end";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@start", SqlDbType.DateTime) { Value = start },
            new SqlParameter("@end", SqlDbType.DateTime) { Value = end }
            };
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            try
            {
                return (double)dataTable.Rows[0]["turnover"];
            }
            catch (Exception)
            {
                throw new InvalidOperationException($"No data found");
            }
        }

        public int GetCustomers(DateTime start, DateTime end)
        {
            string query = "SELECT COUNT(DISTINCT O.studentId) as customers FROM Contain as C INNER JOIN Drink as D ON D.drinkId = C.drinkId INNER JOIN [Order] as O ON O.orderId = C.orderId WHERE O.dateTime BETWEEN @start AND @end";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@start", SqlDbType.DateTime) { Value = start },
            new SqlParameter("@end", SqlDbType.DateTime) { Value = end }
            };
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            try
            {
                return (int)dataTable.Rows[0]["customers"];
            }
            catch (Exception)
            {
                throw new InvalidOperationException($"No data found");
            }
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
