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
		public string Task { get; set; }
		public DateTime Date { get; set; }
		public decimal Hours { get; set; }
		public decimal MaterialCost { get; set; }
	}
}
