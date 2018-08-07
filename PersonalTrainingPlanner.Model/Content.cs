using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalTrainingPlanner.Model
{
    public class Content
    {
        public int ContentId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; } 
        public int ProviderId { get; set; }
    }
}
