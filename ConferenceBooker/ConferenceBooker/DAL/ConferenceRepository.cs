using System;
using System.Collections.Generic;
using ConferenceBooker.Models;

namespace ConferenceBooker.DAL
{
	//Will either connect to Database / WebAPI (TBC)
	public class ConferenceRepository : IConferenceRepository
	{
		private bool _disposed;

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
			throw new NotImplementedException();
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
			throw new NotImplementedException();
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
	}
}