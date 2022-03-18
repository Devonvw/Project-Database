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
    public class OrderDao : BaseDao
    {
        public List<Order> GetAllOrders()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["orderId"];
                float totalPrice = (float)dr["totalPrice"];
                DateTime dateTime = (DateTime)dr["dateTime"];
                int studentId = (int)dr["studentId"];
                int teacherId = (int)dr["teacherId"];

                Order order = new Order(id, totalPrice, dateTime, studentId, teacherId);
                orders.Add(order);
            }

            return orders;
        }
    }
}
