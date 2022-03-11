using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;
using SomerenLogic;
using System.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["studentId"];
                string firstName = (string)(dr["firstName"].ToString());
                string lastName = (string)(dr["lastName"].ToString());
                int roomId = (int)dr["roomId"];
                DateTime birthDate = Convert.ToDateTime(dr["dateOfBirth"]);

                Console.WriteLine(birthDate.ToString());

                Student student = new Student(id, firstName, lastName, roomId, birthDate);
                students.Add(student);
            }


            return students;
        }
    }
}
