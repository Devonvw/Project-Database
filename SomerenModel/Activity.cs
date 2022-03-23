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
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Activity(int activityId, string description, DateTime start, DateTime end)
        {
            ActivityId = activityId;
            Description = description;
            Start = start;
            End = end;
        }
    }
}
