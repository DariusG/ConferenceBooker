using System;
using System.Collections.Generic;
using System.Linq;
using ConferenceBooker.Models;

namespace ConferenceBooker.DAL
{
	public class MockRepository: IConferenceRepository
	{
		private bool _disposed;

		private List<Speaker> speakersList = new List<Speaker>();
		private List<Presentation> presentationsList = new List<Presentation>();

		public MockRepository()
		{
			LoadData();
		}

		public void LoadData()
		{
			speakersList = new List<Speaker>()
			{
				new Speaker()
				{
					Age = 55,
					FirstName = "Bob",
					Surname = "Jones",
					SpeakerId = 1
				},
				new Speaker()
				{
					Age = 24,
					FirstName = "Becky",
					Surname = "Smith",
					SpeakerId = 2,
					ImageUrl = "",
				}
			};

			presentationsList = new List<Presentation>()
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
						FirstName = "Bob Jim",
						Surname = "Jones",
						SpeakerId = 1
					}
				}
			};
		}

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
			return presentationsList;
		}

		public Presentation GetPresentationById(int presentationId)
		{
			return presentationsList.FirstOrDefault(i => i.PresentationId == presentationId);
		}

		public void InsertPresentation(Presentation presentation)
		{
			Presentation lastPresentation = presentationsList.LastOrDefault();

			presentation.PresentationId = lastPresentation.PresentationId + 1;

			presentationsList.Add(presentation);
		}

		public void DeletePresentation(int presentationId)
		{
			Presentation presentation = presentationsList.FirstOrDefault(i => i.PresentationId == presentationId);

			presentationsList.Remove(presentation);
		}

		public void UpdatePresentation(Presentation presentation)
		{
			Presentation presentationToUpdate = presentationsList.FirstOrDefault(i => i.PresentationId == presentation.PresentationId);

			presentationToUpdate.Description = presentation.Description;
			presentationToUpdate.GuestSpeaker = presentation.GuestSpeaker;
			presentationToUpdate.StartTime = presentation.StartTime;
			presentationToUpdate.PresentationId = presentation.PresentationId;
			presentationToUpdate.Duration = presentation.Duration;
			presentationToUpdate.Sponsor = presentation.Sponsor;
			presentationToUpdate.Title = presentation.Title;

			presentationsList.Remove(presentationToUpdate);
			presentationsList.Add(presentation);
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