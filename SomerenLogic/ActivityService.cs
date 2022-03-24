using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class ActivityService
    {
        ActivityDao activitydb;

        public ActivityService()
        {
            activitydb = new ActivityDao();
        }

        public List<Student> GetStudents(int activityId)
        {
            return activitydb.GetStudents(activityId);
        }
        public void AddStudent(int activityId, int studentId)
        {
            activitydb.AddStudent(activityId, studentId);
        }
        public void DeleteStudent(int activityId, int studentId)
        {
            activitydb.DeleteStudent(activityId, studentId);
        }
    }
}
