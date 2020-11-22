using System;
using System.Collections.Generic;
using ConferenceBooker.Models;

namespace ConferenceBooker.DAL
{
	public class MockRepository: IConferenceRepository
	{
		private bool _disposed;

		public IEnumerable<Attendant> GetAttendants()
		{
			throw new NotImplementedException();
		}

		public Attendant GetAttendantById(int attendantId)
		{
			throw new NotImplementedException();
		}

		public void InsertAttendant(Attendant attendant)
		{
			throw new NotImplementedException();
		}

		public void DeleteAttendant(int attendantId)
		{
			throw new NotImplementedException();
		}

		public void UpdateAttendant(Attendant attendant)
		{
			throw new NotImplementedException();
		}

		public void Save()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Speaker> GetSpeakers()
		{
			List<Speaker> speakersList = new List<Speaker>()
			{
				new Speaker()
				{
					Age = 55,
					FirstMidName = "Bob Jim",
					LastName = "Jones",
					SpeakerId = 1
				},
				new Speaker()
				{
				Age = 24,
				FirstMidName = "Becky",
				LastName = "Smith",
				SpeakerId = 2,
				ImageUrl = "",
			}
			};
			return speakersList;
		}

		public Speaker GetSpeakerById(int speakerId)
		{
			throw new NotImplementedException();
		}

		public void InsertSpeaker(Speaker speaker)
		{
			throw new NotImplementedException();
		}

		public void DeleteSpeaker(int speakerId)
		{
			throw new NotImplementedException();
		}

		public void UpdateSpeaker(Speaker speaker)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Presentation> GetPresentations()
		{
			List<Presentation> presentations = new List<Presentation>()
			{
				new Presentation()
				{
					Title = "Law - What is this",
					Description = "A brief look at the origins of this subject",
					StartTime = new DateTime(2021,11,2),
					Duration = new TimeSpan(0,20,0),
					PresentationId = 1,
					Sponsor = "Law Special",
					GuestSpeaker = new Speaker()
					{
						Age = 55,
						FirstMidName = "Bob Jim",
						LastName = "Jones",
						SpeakerId = 1
					}
				}
			};

			return presentations;
		}

		public Presentation GetPresentationById(int presentationId)
		{
			throw new NotImplementedException();
		}

		public void InsertPresentation(Presentation presentation)
		{
			throw new NotImplementedException();
		}

		public void DeletePresentation(int presentationId)
		{
			throw new NotImplementedException();
		}

		public void UpdatePresentation(Presentation presentation)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		protected virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				if (disposing)
				{
					// Clear all property values that maybe have been set
					// when the class was instantiated

				}
				_disposed = true;
			}
		}
	}
}