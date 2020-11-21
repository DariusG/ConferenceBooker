using System.Collections.Generic;

namespace ConferenceBooker.Models
{
	public class Speaker
	{
		public int SpeakerId { get; set; }
		public string LastName { get; set; }
		public string FirstMidName { get; set; }
		public int Age { get; set; }
		public List<Publication> Publications { get; set; }
		public string ImageUrl { get; set; }
	}
}