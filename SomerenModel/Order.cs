using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public int Id { get; set; } // StudentNumber, e.g. 474791
        public float TotalPrice { get; set; }
        public DateTime DateTime { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }

        public Order(int id, float totalPrice, DateTime dateTime, int studentId, int teacherId)
        {
            Id = id;
            TotalPrice = totalPrice;
            DateTime = dateTime;
            StudentId = studentId;
            TeacherId = teacherId;
        }
    }
}
