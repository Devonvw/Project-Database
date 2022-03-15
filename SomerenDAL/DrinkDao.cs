using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetDrinks()
        {
            string query = "SELECT drinkId, name, stock, price, vatId, amountSold FROM Drink";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                //for each row, each column value as a parameter for the object 
                int id = (int)dr["drinkId"];
                string name = (string)(dr["name"]).ToString();
                int stock = (int)dr["stock"];
                float price = (float)dr["price"];
                int vatId = (int)dr["vatId"];
                int amountSold = (int)dr["amountSold"];


                Drink drink = new Drink(id, name, stock, price, vatId, amountSold);
                drinks.Add(drink);
            }

            return drinks;
        }
    }
}
