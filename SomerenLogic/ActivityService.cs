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
        public void AddActivity(Activity activity)
        {
            activitydb.AddActivity(activity);
        }
        public void UpdateActivity(Activity activity)
        {
            activitydb.UpdateActivity(activity);
        }
        public void DeleteActivity(Activity activity)
        {
            activitydb.DeleteActivity(activity);
        }
    }
}
