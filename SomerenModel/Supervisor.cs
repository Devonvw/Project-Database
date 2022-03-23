using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Supervisor
    {
        public int TeacherId { get; set; } // LecturerNumber, e.g. 47198
        public int ActivityId { get; set; }

        public Supervisor(int teacherId, int activityId)
        {
            TeacherId = teacherId;
            ActivityId = activityId;
        }
    }
}
