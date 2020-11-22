using System.Collections.Generic;

namespace ConferenceBooker.Models
{
	public class Speaker
	{
		public int SpeakerId { get; set; } = -1;
		public string LastName { get; set; } 
		public string FirstMidName { get; set; }
		public int Age { get; set; } = -1;
		public List<Publication> Publications { get; set; } = new List<Publication>();
		public string ImageUrl { get; set; } 
	}
}