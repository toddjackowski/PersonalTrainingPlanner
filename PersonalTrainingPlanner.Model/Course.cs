using System;

namespace PersonalTrainingPlanner.Model
{
    public class Course : Content
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Cost { get; set; }
    }
}
