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
        public string ActivityDescription { get; set; }
        public DateTime ActivityStartDateTime { get; set; }
        public DateTime ActivityEndDateTime { get; set; }
        public Activity(int activityId, string description, DateTime startDateTime, DateTime endDateTime)
        {
            ActivityId = activityId;
            ActivityDescription = description;
            ActivityStartDateTime = startDateTime;
            ActivityEndDateTime = endDateTime;
        }
    }
}