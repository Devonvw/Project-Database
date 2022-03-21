using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;
using System.Diagnostics;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Student> GetStudents(int activityId)
        {
            string query = "SELECT S.* from Activity as A LEFT JOIN ActivityStudent as ASTU ON A.activityId = ASTU.activityId LEFT JOIN Student as S ON S.studentId = ASTU.studentId WHERE A.activityId = @activityId";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@activityId", SqlDbType.DateTime) { Value = activityId },
            };

            try
            {
                return ReadStudents(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception)
            {
                throw new InvalidOperationException($"No data found");
            }
        }
        public void AddStudent(int activityId, int studentId)
        {
            string query = "INSERT INTO ActivityStudent (activityId, studentId) VALUES(@activityId, @studentId)";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@activityId", SqlDbType.DateTime) { Value = activityId },
            new SqlParameter("@studentId", SqlDbType.DateTime) { Value = studentId }
            };

            try
            {
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception)
            {
                throw new InvalidOperationException($"Not able to add student.");
            }
        }
        public List<Activity> GetActivity()
        {
            string query = "SELECT activityId, startDateTime, description, endDateTime FROM Activity";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateActivity(Activity activity)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("UPDATE Activity SET startDateTime=@startDatetime, description=@description endDateTime=@endDateTime WHERE activityId=@activityId;", conn);
            command.Parameters.AddWithValue("@activityId", activity.ActivityId);
            command.Parameters.AddWithValue("@startDateTime", activity.ActivityStartDateTime);
            command.Parameters.AddWithValue("@description", activity.ActivityDescription);
            command.Parameters.AddWithValue("@endDateTime", activity.ActivityEndDateTime);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void AddActivity(Activity activity)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Activity(activityId, description, startDateTime, endDateTime) VALUES(@activityId, @description, @startDateTime, @endDateTime);", conn);
            command.Parameters.AddWithValue("@activityId", activity.ActivityId);
            command.Parameters.AddWithValue("@description", activity.ActivityDescription);
            command.Parameters.AddWithValue("@startDateTime", activity.ActivityStartDateTime);
            command.Parameters.AddWithValue("@endDateTime", activity.ActivityEndDateTime);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteActivity(Activity activity)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Activity WHERE activityId=@activityId");
            command.Parameters.AddWithValue("@activityId", activity.ActivityId);
            command.ExecuteNonQuery();
            conn.Close();
        }
        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int activityId = (int)dr["activityId"];
                DateTime startDateTime = (DateTime)dr["startDateTime"];
                string description = (string)(dr["description"]);
                DateTime endDateTime = (DateTime)dr["endDateTime"];
                string activityName = (string)(dr["activityName"]);

                Activity activity = new Activity(activityId, description, startDateTime, endDateTime);
                activities.Add(activity);
            }
            return activities;
        }
        public void DeleteStudent(int activityId, int studentId)
        {
            string query = "DELETE FROM ActivityStudent WHERE studentId = @studentId AND activityId = @activityId";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@activityId", SqlDbType.DateTime) { Value = activityId },
            new SqlParameter("@studentId", SqlDbType.DateTime) { Value = studentId }
            };

            try
            {
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception)
            {
                throw new InvalidOperationException($"Not able to delete student.");
            }
        }

        private List<Student> ReadStudents(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                //for each row, each column value as a parameter for the object 
                int id = (int)dr["studentId"];
                string firstName = (string)(dr["firstName"]).ToString();
                string lastName = (string)(dr["lastName"]);
                int roomId = (int)dr["roomId"];
                DateTime birthDate = Convert.ToDateTime(dr["dateOfBirth"]); //NULL not allowed in this case 

                Student student = new Student(id, firstName, lastName, roomId, birthDate);
                students.Add(student);
            }

            return students;
        }
    }

}