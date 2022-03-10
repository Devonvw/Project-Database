using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Room
    {
        public int Id { get; set; } // RoomNumber, e.g. 206
        public int Capacity { get; set; } // number of beds, either 4,6,8,12 or 16
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
    }
}
