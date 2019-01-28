using System;
using System.Collections.Generic;

namespace FiveSTARProjectTracking.Model
{
    public partial class Tasks
    {
        public int TaskId { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? VendorId { get; set; }
        public int? LocationId { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedById { get; set; }
        public int? CostTypeId { get; set; }
        public decimal? EstimatedCost { get; set; }
        public decimal? ActualCost { get; set; }
        public decimal? EstimatedHours { get; set; }
        public decimal? ActualHours { get; set; }

        public CostTypes CostType { get; set; }
        public AspNetUsers CreatedBy { get; set; }
        public Locations Location { get; set; }
        public Projects Project { get; set; }
        public Vendors Vendor { get; set; }
    }
}
