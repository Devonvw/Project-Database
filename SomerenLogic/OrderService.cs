using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class OrderService
    {
        OrderDao orderdb;
        public OrderService()
        {
            orderdb = new OrderDao();
        }
        public List<Order> GetOrders()
        {
            List<Order> orders = orderdb.GetAllOrders();
            return orders;
        }
        public void AddOrder(int studentId, DateTime birthDate, List<OrderLine> orderLines)
        {
            orderdb.AddOrder(studentId, birthDate, orderLines);
        }
    }
}