using System;

namespace ConferenceBooker.Models
{
	public class Presentation
	{
		public int PresentationId { get; set; } 
		public string Title { get; set; }
		public string Description { get; set; }
		public Speaker GuestSpeaker { get; set; } 
		public DateTime StartTime { get; set; }
		public TimeSpan Duration { get; set; }
		public string Sponsor { get; set; }
	}
}