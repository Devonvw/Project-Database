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
        public List<Activity> GetActivity()
        {
            string query = "SELECT description, startDateTime, endDateTime, activityId FROM Activity";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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

                Activity activity = new Activity(activityId, description, startDateTime, endDateTime);
                activities.Add(activity);
            }
            return activities;
        }
        public void DeleteSupervisor(int teacherId, int activityId)
        {
            try
            {
                string query = "DELETE FROM ActivitySupervisor WHERE teacherId=@teacherId AND activityId=@activityId;";

                SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@teacherId", teacherId), new SqlParameter("@activityId", activityId) };

                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }
        }
        public List<Teacher> GetSupervisorsOfActivity(int activityId)
        {
            string query = "SELECT teacher.* FROM ActivitySupervisor JOIN Activity ON ActivitySupervisor.activityId = Activity.activityId JOIN Teacher ON teacher.teacherId = ActivitySupervisor.teacherId where activity.activityId=@activityId ORDER BY Teacher.firstName";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@activityId", activityId) };

            return ReadSupervisors(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Teacher> ReadSupervisors(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int teacherId = (int)dr["teacherId"];
                string firstName = (string)(dr["firstName"]).ToString();
                string lastName = (string)(dr["lastName"]);
                int classId = (int)(dr["class"]);
                int roomId = (int)dr["roomId"];

                Teacher teacher = new Teacher(teacherId, firstName, lastName, classId, roomId);
                teachers.Add(teacher);
            }
            return teachers;
        }
        public void AddSuperVisor(int activityId, int teacherId)
        {
            string query = "SELECT startDateTime, endDateTime from Activity WHERE activityId = @activityId";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@activityId", activityId),
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            DateTime start = (DateTime)dataTable.Rows[0]["startDateTime"];
            DateTime end = (DateTime)dataTable.Rows[0]["endDateTime"];

            query = "SELECT * from Activity JOIN ActivitySupervisor ON Activity.activityId = ActivitySupervisor.activityId JOIN Teacher ON Teacher.teacherId = ActivitySupervisor.teacherId WHERE Teacher.teacherId = @teacherId and (Activity.startDateTime BETWEEN @startDateTime and @endDateTime or Activity.endDateTime BETWEEN @startDateTime and @endDateTime);";
            SqlParameter[] sqlParametersAvailable = new SqlParameter[]
            {
            new SqlParameter("@teacherId", teacherId),
            new SqlParameter("@startDateTime", SqlDbType.DateTime) { Value = start },
            new SqlParameter("@endDateTime", SqlDbType.DateTime) { Value = end }
            };

            dataTable = ExecuteSelectQuery(query, sqlParametersAvailable);

            if (dataTable != null)
            {
                if (dataTable.Rows.Count > 0)
                {
                    throw new InvalidProgramException();
                }
            }

            string queryy = "INSERT INTO ActivitySupervisor(teacherId, activityId) VALUES(@teacherId, @activityId);";

            SqlParameter[] sqlParametersAdd = new SqlParameter[]
            {
                new SqlParameter("@activityId", activityId),
                new SqlParameter("@teacherId", teacherId)
            };

            ExecuteEditQuery(queryy, sqlParametersAdd);
        }
    }
}
