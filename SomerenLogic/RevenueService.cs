using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class RevenueService
    {
        RevenueDao revenuedb;

        public RevenueService()
        {
            revenuedb = new RevenueDao();
        }

        public int GetSales(DateTime start, DateTime end)
        {
            return revenuedb.GetSales(start, end);
        }
        public double GetTurnover(DateTime start, DateTime end)
        {
            return revenuedb.GetTurnover(start, end);
        }
        public int GetCustomers(DateTime start, DateTime end)
        {
            return revenuedb.GetCustomers(start, end);
        }
    }
}
