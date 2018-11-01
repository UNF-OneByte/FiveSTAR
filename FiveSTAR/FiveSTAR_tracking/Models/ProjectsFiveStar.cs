using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveSTAR_tracking.Models
{
    public class ProjectsFiveStar
    {
        public string ID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManager { get; set; }
        public string Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EstEndtDate { get; set; }
        public DateTime ActEndDate { get; set; }

        public decimal EstCost { get; set; }
        public decimal ActCost { get; set; }

        public decimal EstHours { get; set; }
        public decimal ActHours { get; set; }

        public int IdUsers { get; set; }
    }
}
