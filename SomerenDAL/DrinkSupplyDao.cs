using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class DrinkSupplyDao : BaseDao
    {
        public List<DrinkSupply> GetAllDrinkSupplies()
        {
            string query = "SELECT [name], stock = (stock - SUM(Contain.amount)), price, SUM(Contain.amount) AS [amount] " +
                           "FROM Drink, Contain " +
                           "WHERE Drink.drinkId = Contain.drinkId " +
                           "GROUP BY [name], stock, Price " +
                           "HAVING Drink.price > 1 AND Drink.price > 1 " +
                           "ORDER BY stock DESC, price, [amount] DESC;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<DrinkSupply> ReadTables(DataTable dataTable)
        {
            List<DrinkSupply> drinksSupplies = new List<DrinkSupply>();

            foreach (DataRow dr in dataTable.Rows)
            {
                string name = (string)(dr["name"]).ToString();
                int stock = (int)(dr["stock"]);
                double price = (double)dr["price"];
                int amount = (int)(dr["amount"]);

                DrinkSupply drinkSuply = new DrinkSupply(name, stock, price, amount);
                drinksSupplies.Add(drinkSuply);
            }

            return drinksSupplies;
        }
    }

}
