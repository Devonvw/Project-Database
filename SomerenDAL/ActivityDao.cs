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
            new SqlParameter("@activityId", SqlDbType.Int) { Value = activityId },
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
            DateTime start = new DateTime();
            DateTime end = new DateTime();
            string query = "SELECT A.* from Activity as A WHERE A.activityId = @activityId";

            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@activityId", SqlDbType.Int) { Value = activityId },
                };

                DataTable dataTable = new DataTable();

                dataTable = ExecuteSelectQuery(query, sqlParameters);
                start = (DateTime)dataTable.Rows[0]["startDateTime"];
                end = (DateTime)dataTable.Rows[0]["endDateTime"];

                query = "SELECT A.* from Activity as A LEFT JOIN ActivityStudent as ASTU ON A.activityId = ASTU.activityId LEFT JOIN Student as S ON S.studentId = ASTU.studentId WHERE S.studentId = @studentId and (A.startDateTime BETWEEN @startDateTime and @endDateTime or A.endDateTime BETWEEN @startDateTime and @endDateTime)";
                SqlParameter[] sqlParametersAvailable = new SqlParameter[]
                {
                    new SqlParameter("@studentId", SqlDbType.Int) { Value = studentId },
                    new SqlParameter("@startDateTime", SqlDbType.DateTime) { Value = start },
                    new SqlParameter("@endDateTime", SqlDbType.DateTime) { Value = end },
                };

                dataTable = ExecuteSelectQuery(query, sqlParametersAvailable);

                if (dataTable != null)
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        throw new InvalidOperationException($"This student already has an activity in this timespan");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"{ex.Message}");
            }


            query = "INSERT INTO ActivityStudent (activityId, studentId) VALUES(@activityId, @studentId)";

            SqlParameter[] sqlParametersAdd = new SqlParameter[]
            {
            new SqlParameter("@activityId", SqlDbType.Int) { Value = activityId },
            new SqlParameter("@studentId", SqlDbType.Int) { Value = studentId }
            };

            try
            {
                ExecuteEditQuery(query, sqlParametersAdd);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Not able to add student. {activityId} {studentId} {ex.Message}");
            }
        }

        public void DeleteStudent(int activityId, int studentId)
        {
            string query = "DELETE FROM ActivityStudent WHERE studentId = @studentId AND activityId = @activityId";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@activityId", SqlDbType.Int) { Value = activityId },
            new SqlParameter("@studentId", SqlDbType.Int) { Value = studentId }
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
                string firstName = (string)(dr["firstName"]);
                string lastName = (string)(dr["lastName"]);
                int roomId = (int)dr["roomId"];
                DateTime birthDate = Convert.ToDateTime(dr["dateOfBirth"]); //NULL not allowed in this case 

                Student student = new Student(id, firstName, lastName, roomId, birthDate);
                students.Add(student);
            }

            return students;
        }
        public List<Activity> GetActivity()
        {
            string query = "SELECT description, startDateTime, endDateTime, activityId FROM Activity";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateActivity(Activity activity)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("UPDATE Activity SET startDateTime=@startDatetime, description=@description, endDateTime=@endDateTime WHERE activityId=@activityId;", conn);
            command.Parameters.AddWithValue("@startDateTime", activity.ActivityStartDateTime);
            command.Parameters.AddWithValue("@description", activity.ActivityDescription);
            command.Parameters.AddWithValue("@endDateTime", activity.ActivityEndDateTime);

            command.Parameters.AddWithValue("@activityId", activity.ActivityId);

            command.ExecuteNonQuery();
            conn.Close();
        }
        public void AddActivity(Activity activity)
        {
            string query = "INSERT INTO Activity(activityId, description, startDateTime, endDateTime) VALUES(@activityId, @description, @startDateTime, @endDateTime) SELECT SCOPE_IDENTITY();";

            List<Activity> activityList = GetActivity();

            //activity.ActivityId = 1;
            foreach (Activity dr in activityList)
            {
                while (activity.ActivityId == dr.ActivityId)
                {
                    activity.ActivityId++;
                }
            }

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                    new SqlParameter("@activityId", activity.ActivityId),
                    new SqlParameter("@description", activity.ActivityDescription),
                    new SqlParameter("@startDateTime", activity.ActivityStartDateTime),
                    new SqlParameter("@endDateTime", activity.ActivityEndDateTime)
            };
            ExecuteEditQuery(query, sqlParameters);

        }
        public void DeleteActivity(int activityId)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@activityId", SqlDbType.Int) { Value = activityId },
            };

            string query = $"DELETE FROM Activity WHERE activityId=@activityId";
            ExecuteEditQuery(query, sqlParameters);
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
