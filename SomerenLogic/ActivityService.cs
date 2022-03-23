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
            List<Activity> activities = activitydb.GetActivities();
            return activities;
        }
        public List<Supervisor> GetSupervisors()
        {
            List<Supervisor> supervisors = activitydb.GetSupervisors();
            return supervisors;
        }
        public void AddSupervisors(Supervisor supervisor)
        {
            activitydb.AddSupervisor(supervisor);
        }
        public void DeleteSupervisor(Supervisor supervisor)
        {
            activitydb.DeleteSupervisor(supervisor);
        }
    }
}
