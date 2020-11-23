using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConferenceBooker.Models
{
	public class Presentation
	{
		public int PresentationId { get; set; } 
		
		[Required]
		[MaxLength(200,ErrorMessage = "Title Length is too long, please shorten")]
		public string Title { get; set; }
		public string Description { get; set; }
		public Speaker GuestSpeaker { get; set; } = null;
		
		[DataType(DataType.DateTime)]
		public DateTime? StartTime { get; set; }

		public Int64 TimeSpanTicks { get; set; }
		[NotMapped]
		[DataType(DataType.Duration)]
		public TimeSpan Duration {
			get { return TimeSpan.FromTicks(TimeSpanTicks); }
			set { TimeSpanTicks = value.Ticks; }
		}

		[Display(Name = "Sponsor")]
		public string Sponsor { get; set; }
	}
}