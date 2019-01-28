using System;
using System.Collections.Generic;

namespace FiveSTARProjectTracking.Model
{
    public partial class Projects
    {
        public Projects()
        {
            Tasks = new HashSet<Tasks>();
        }

        public int ProjectId { get; set; }
        public string ProjectManagerId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? EstimatedStartDate { get; set; }
        public DateTime? EstimatedEndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public decimal? EstimatedInitialCost { get; set; }
        public decimal? EstimatedInitialHours { get; set; }

        public AspNetUsers ProjectManager { get; set; }
        public ICollection<Tasks> Tasks { get; set; }
    }
}
