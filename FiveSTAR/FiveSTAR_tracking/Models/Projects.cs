using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiveSTAR_tracking.Models
{
	public class Projects
	{
		public string ID { get; set; }
		public string TaskName { get; set; }
		public decimal Task_Est_Cost { get; set; }
		public decimal Task_Act_Cost { get; set; }
		public int idVendor { get; set; }
		public DateTime Date { get; set; }

		public decimal HoursWorked { get; set; }
		public int idUsers { get; set; }
	}
}
