using System;
using System.Collections.Generic;
using ConferenceBooker.Models;

namespace ConferenceBooker.DAL
{
	interface IConferenceRepository : IDisposable
	{
		//Attendants
		IEnumerable<Attendant> GetAttendants();
		Attendant GetAttendantById(int attendantId);
		void InsertAttendant(Attendant attendant);
		void DeleteAttendant(int attendantId);
		void UpdateAttendant(Attendant attendant);
		void Save();

		//Speakers
		IEnumerable<Speaker> GetSpeakers();
		Speaker GetSpeakerById(int speakerId);
		void InsertSpeaker(Speaker speaker);
		void DeleteSpeaker(int speakerId);
		void UpdateSpeaker(Speaker speaker);

		//Presentations
		IEnumerable<Presentation> GetPresentations();
		Presentation GetPresentationById(int presentationId);
		void InsertPresentation(Presentation presentation);
		void DeletePresentation(int presentationId);
		void UpdatePresentation(Presentation presentation);
	}
}
