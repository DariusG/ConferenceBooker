using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConferenceBooker.Models
{
	public class Speaker
	{
		public int SpeakerId { get; set; } = -1;

		[Required]
		[Display(Description = "Surname")]
		[MaxLength(100, ErrorMessage = "Surname  is to long, please shorten")]
		public string Surname { get; set; } 

		[Required]
		[Display(Description = "First name")]
		[MaxLength(100,ErrorMessage = "First Name is to long, please shorten")]
		public string FirstName { get; set; }

		[Display(Description = "Age")]
		public int Age { get; set; } = -1;
		public List<Publication> Publications { get; set; } = new List<Publication>();
		public string ImageUrl { get; set; } 
	}
}