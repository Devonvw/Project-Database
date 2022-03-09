using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {      
        public List<Student> GetAllStudents()
        {
            string query = "SELECT studentId, firstName, lastName, dateOfBirth FROM Student";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["studentId"];
                string firstName = (string)(dr["firstName"].ToString());
                string lastName = (string)(dr["lastName"].ToString());              
                DateTime birthDate = (DateTime)dr["birthDate"];
                int roomId = (int)dr["roomId"];

                Student student = new Student(id, firstName, lastName, birthDate, roomId);
                students.Add(student);
            }
            return students;
        }
    }
}
