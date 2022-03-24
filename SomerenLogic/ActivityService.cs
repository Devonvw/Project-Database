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
        public List<Activity> GetActivities()
        {
            List<Activity> activities = activitydb.GetActivity();
            return activities;
        }
        public void DeleteSupervisor(int teacherId, int activityId)
        {
            activitydb.DeleteSupervisor(teacherId, activityId);
        }
        public List<Teacher> GetSupervisorsOfActivity(int activityId)
        {
            List<Teacher> activitySupervisors = activitydb.GetSupervisorsOfActivity(activityId);
            return activitySupervisors;
        }
        public void AddSuperVisor(int activityId, int teacherId)
        {
            activitydb.AddSuperVisor(activityId, teacherId);
        }
    }
}
