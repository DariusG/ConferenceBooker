using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConferenceBooker.Models
{
	public class Attendant
	{
		public int AttendantId { get; set; } = -1;
		public string LastName { get; set; }
		public string FirstMidName { get; set; }
		public DateTime RegisteredDate { get; set; } = DateTime.MinValue;
	}
}