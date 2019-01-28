using System;
using System.Collections.Generic;

namespace FiveSTARProjectTracking.Model
{
    public partial class Vendors
    {
        public Vendors()
        {
            Tasks = new HashSet<Tasks>();
        }

        public int VendorId { get; set; }
        public string Name { get; set; }
        public decimal? Phone { get; set; }
        public string Zipcode { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Organization { get; set; }

        public ICollection<Tasks> Tasks { get; set; }
    }
}
