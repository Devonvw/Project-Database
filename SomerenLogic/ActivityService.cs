using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

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
        public List<Activity> GetActivity()
        {
            List<Activity> activities = activitydb.GetActivity();
            return activities;
        }
        public void AddActivity(Activity activity)
        {
            activitydb.AddActivity(activity);
        }
        public void UpdateActivity(Activity activity)
        {
            activitydb.UpdateActivity(activity);
        }
        public void DeleteActivity(int activityId)
        {
            activitydb.DeleteActivity(activityId);
        }
    }
}
