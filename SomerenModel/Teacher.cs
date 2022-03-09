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
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public Teacher(string firstName, string lastName, int teacherId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.TeacherId = teacherId;
        }
    }
}
