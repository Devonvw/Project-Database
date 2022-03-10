using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TeacherId { get; set; } // LecturerNumber, e.g. 47198
        public int RoomId { get; set; }
        public int ClassId { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public Teacher(int teacherId, string firstName, string lastName, int classId, int roomId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.TeacherId = teacherId;
            this.ClassId = classId;
            this.RoomId = roomId;
        }
    }
}
