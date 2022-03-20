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
    public class OrderDao : BaseDao
    {
        public List<Order> GetAllOrders()
        {
            string query = "INSERT INTO Order (totalPrice, dateTime, studentId) " +
                            "VALUES (@TotalPrice, @DateTime, @StudentId); " +
                            "SELECT SCOPE_IDENTITY();";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddOrder(int studentId, DateTime birthDate, List<OrderLine> orderLines)
        {
            int orderId = 0;
            int age = 0;

            try
            {
                // calculate age
                DateTime today = DateTime.Today;
                age = today.Year - birthDate.Year;

                // if leap year
                if (birthDate.Date > today.AddYears(-age)) age--;

                if (age < 18)
                {
                    foreach (OrderLine orderLine in orderLines)
                    {
                        if (orderLine.Drink.VatId == 2)
                        {
                            throw new Exception("You are too young for alcoholic drinks! ");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            //School versie
            conn.Open();

            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

            string query = "INSERT INTO [Order] (dateTime, studentId) " +
                            "VALUES (@DateTime, @StudentId) " +
                            "SELECT SCOPE_IDENTITY() AS OrderId;";
            //return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@DateTime", SqlDbType.DateTime) { Value = DateTime.Now },
            new SqlParameter("@StudentId", SqlDbType.Int) { Value = studentId }
            };
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            DataRow dataRow = dataTable.Rows[0];
            orderId = int.Parse(dataRow[0].ToString());
            conn.Close();


            conn.Open();
            foreach (OrderLine line in orderLines)
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Contain] (orderId, drinkId, amount) " +
                            "VALUES (@OrderId, @DrinkId, @Amount) " +
                            "SELECT SCOPE_IDENTITY() AS OrderId;", conn);
                command.Parameters.AddWithValue("@OrderId", orderId);
                command.Parameters.AddWithValue("@DrinkId", line.Drink.Id);
                command.Parameters.AddWithValue("@Amount", line.Amount);
                command.ExecuteNonQuery();
            }

            conn.Close();
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