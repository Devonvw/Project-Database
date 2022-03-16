using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class DrinkSupplyDao : BaseDao
    {
        public List<DrinkSupply> GetAllDrinkSupplies()
        {
            UpdateAmountOfSalesForEachDrink();

            string query = "select drinkId, [name], stock, price, vatId, COALESCE(amountSold, 0) AS amount " +
                           "FROM Drink " +
                           "GROUP BY drinkId, [name], stock, price, amountSold, vatId " +
                           "HAVING Drink.stock > 1 AND Drink.price > 1 " +
                           "ORDER BY stock, price, [amount] DESC;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<DrinkSupply> ReadTables(DataTable dataTable)
        {
            List<DrinkSupply> drinksSupplies = new List<DrinkSupply>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int drinkId = (int)(dr["drinkId"]);
                string name = (string)(dr["name"]).ToString();
                int stock = (int)(dr["stock"]);
                double price = (double)dr["price"];
                int vatId = (int)(dr["vatId"]);
                int amount = (int)(dr["amount"]);

                DrinkSupply drinkSuply = new DrinkSupply(drinkId, name, stock, price, vatId, amount);
                drinksSupplies.Add(drinkSuply);
            }

            return drinksSupplies;
        }
        public int GenerateId()
        {
            string queryID = $"SELECT TOP 1 drinkId FROM Drink ORDER BY drinkId DESC;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(queryID, sqlParameters);
            return (int)dataTable.Rows[0]["drinkId"] + 1;
        }
        public void UpdateAmountOfSalesForEachDrink()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = OpenConnection();
            string queryID = $"UPDATE Drink SET amountSold = (SELECT SUM(amount) AS sales FROM Contain WHERE drinkId = Drink.drinkId);";
            command.CommandText = queryID;
            command.ExecuteNonQuery();
            command.Connection.Close();
        }
        public void AddDrinkSupply(DrinkSupply drink)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = OpenConnection();
            string query = "SET IDENTITY_INSERT Drink ON INSERT INTO Drink(drinkId, [name], stock, price, vatId, amountSold) VALUES(@drinkId, @name, @stock, @price, @vatId, @amount) SET IDENTITY_INSERT Drink OFF;";
            command.CommandText = query;
            command.Parameters.AddWithValue("@drinkId", drink.DrinkId);
            command.Parameters.AddWithValue("@name", drink.DrinkName);
            command.Parameters.AddWithValue("@stock", drink.Stock);
            command.Parameters.AddWithValue("@price", drink.Price);
            command.Parameters.AddWithValue("@vatId", drink.VatId);
            command.Parameters.AddWithValue("@amount", drink.AmountSold);
            command.ExecuteNonQuery();
            command.Connection.Close();
            
        }
        public void UpdateDrinkSupply(DrinkSupply drink)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = OpenConnection();
            string query = "UPDATE Drink SET [name]=@name, stock=@stock, price=@price WHERE drinkId=@drinkId;";
            command.CommandText = query;
            command.Parameters.AddWithValue("@drinkId", drink.DrinkId);
            command.Parameters.AddWithValue("@name", drink.DrinkName);
            command.Parameters.AddWithValue("@stock", drink.Stock);
            command.Parameters.AddWithValue("@price", drink.Price);
            command.ExecuteNonQuery();
            command.Connection.Close();
        }
        public void DeleteDrinkSupply(DrinkSupply drink)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = OpenConnection();
            string query = "DELETE FROM Drink WHERE drinkId=@drinkId;";

            command.CommandText = query;
            command.Parameters.AddWithValue("@drinkId", drink.DrinkId);
            command.ExecuteNonQuery();
            command.Connection.Close();
        }
    }
}
