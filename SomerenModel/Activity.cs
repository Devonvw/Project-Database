using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public DateTime ActivityStartDateTime { get; set; }
        public DateTime ActivityEndDateTime { get; set; }
        public string ActivityDescription { get; set; }
        public int ActivityTypeId { get; set; }
        public string ActivityName { get; set; }
        public Activity(int activityId, DateTime startDateTime, int activityTypeId, string description, DateTime endDateTime, string activityName)
        {
            ActivityId = activityId;
            ActivityStartDateTime = startDateTime;
            ActivityTypeId = activityTypeId;
            ActivityDescription = description;
            ActivityEndDateTime = endDateTime;
            ActivityName = activityName;
        }
    }
}