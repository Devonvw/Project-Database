using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Student
    {
        public int Id { get; set; } // StudentNumber, e.g. 474791
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string FullName { get { return $"{ FirstName } { LastName }"; } }
        public int RoomId { get; set; }

        public Student(int id, string firstName, string lastName, int roomId, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            BirthDate = birthDate;
            RoomId = roomId;
        }
        public override string ToString()
        {
            return $"{Id} {FullName} {BirthDate} {RoomId}";
        }
    }
}
