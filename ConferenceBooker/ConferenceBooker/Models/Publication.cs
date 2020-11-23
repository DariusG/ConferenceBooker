using System;

namespace ConferenceBooker.Models
{
	public class Publication
	{
		public int PublicationId { get; set; } = -1;
		public string Title { get; set; } 
		public string Author { get; set; } 
		public DateTime? PublicationDate { get; set; }
		public string Journal { get; set; }
	}
}