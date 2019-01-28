using System;
using System.Collections.Generic;

namespace FiveSTARProjectTracking.Model
{
    public partial class Locations
    {
        public Locations()
        {
            Tasks = new HashSet<Tasks>();
        }

        public int LocationId { get; set; }
        public string Name { get; set; }
        public string RoomNumber { get; set; }
        public string Description { get; set; }

        public ICollection<Tasks> Tasks { get; set; }
    }
}
