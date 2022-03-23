using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;


namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetActivities()
        {
            string query = "select * from Activity;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["activityId"];              
                DateTime startTime = Convert.ToDateTime(dr["startDateTime"]);
                string description = (string)(dr["description"]).ToString();
                DateTime endTime = Convert.ToDateTime(dr["endDateTime"]);


                Activity activity = new Activity(id, description, startTime, endTime);
                activities.Add(activity);
            }
            return activities;
        }
        public List<Supervisor> GetSupervisors()
        {
            string query = "select * from ActivitySupervisor;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesFromSupervisors(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Supervisor> ReadTablesFromSupervisors(DataTable dataTable)
        {
            List<Supervisor> supervisors = new List<Supervisor>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int teacherId = (int)dr["teacherId"];
                int activityId = (int)dr["activityId"];


                Supervisor supervisor = new Supervisor(teacherId, activityId);
                supervisors.Add(supervisor);
            }
            return supervisors;
        }
        public void AddSupervisor(Supervisor supervisor)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = OpenConnection();
            string query = "INSERT INTO ActivitySupervisor(teacherId, activityId) VALUES(@teacherId, @activityId);";
            command.CommandText = query;
            command.Parameters.AddWithValue("@teacherId", supervisor.TeacherId);
            command.Parameters.AddWithValue("@activityId", supervisor.ActivityId);
            command.ExecuteNonQuery();
            command.Connection.Close();

        }
        public void DeleteSupervisor(Supervisor supervisor)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = OpenConnection();
            string query = "DELETE FROM ActivitySupervisor WHERE teacherId=@teacherId;";
            command.CommandText = query;
            command.Parameters.AddWithValue("@teacherId", supervisor.TeacherId);
            command.ExecuteNonQuery();
            command.Connection.Close();

        }
    }
}
