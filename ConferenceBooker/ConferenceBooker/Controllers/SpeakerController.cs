using System;
using System.Data.Entity.Migrations;
using System.Web.Mvc;
using ConferenceBooker.DAL;
using ConferenceBooker.Models;

namespace ConferenceBooker.Controllers
{
    public class SpeakerController : Controller
    {
	    IConferenceRepository _conferenceRepository = new ConferenceRepository();
        //EF
	    private ConferenceContext _db = new ConferenceContext();

        public SpeakerController(IConferenceRepository repo)
	    {
		    _conferenceRepository = repo;
	    }

	    public SpeakerController()
	    {
		    _conferenceRepository = new MockRepository();
	    }
        // GET: Speaker
        public ActionResult Index()
        {
			//var speakers = _conferenceRepository.GetSpeakers();
			var speakers = _db.SpeakerEntries;
            return View(speakers);
        }

        public ActionResult Create()
        {
	        var speakers = new Speaker();
	        return View(speakers);
        }

        [HttpPost]
        public ActionResult Create(Speaker speaker)
        {
	        if (ModelState.IsValid)
	        {
		        _db.SpeakerEntries.Add(speaker);
		        _db.SaveChanges();

				//_conferenceRepository.InsertSpeaker(speaker);
				//return View("Index", _conferenceRepository.GetSpeakers());
				return View("Index", _db.SpeakerEntries);
	        }
	        return View(speaker);
        }

        public ActionResult Edit(int id)
        {
	        if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));
	        //Presentation presentation = _conferenceRepository.GetPresentationById(id);
	        Speaker speaker = _db.SpeakerEntries.Find(id);

	        return View(speaker);
        }

        [HttpPost]
        public ActionResult Edit(Speaker speaker)
        {
	        if (ModelState.IsValid)
	        {
		        //_conferenceRepository.UpdatePresentation(presentation);
		        _db.SpeakerEntries.AddOrUpdate(speaker);
		        //return View("Index",_conferenceRepository.GetSpeakers()); 
		        return View("Index", _db.SpeakerEntries);
	        }

	        return View(speaker);
        }

        public ActionResult Details(int id)
        {
	        if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));
	        //Speaker speaker = _conferenceRepository.GetSpeakerById(id);
	        Speaker speaker = _db.SpeakerEntries.Find(id);
	        return View(speaker);
        }

        public ActionResult Delete(int id)
        {
	        if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));
	        //_conferenceRepository.DeleteSpeaker(id);
	        Speaker speaker = _db.SpeakerEntries.Find(id);
	        if (speaker != null)
	        {
		        _db.SpeakerEntries.Remove(speaker);
		        _db.SaveChanges();
	        }
	        //return View("Index", _conferenceRepository.GetSpeakers());
	        return View("Index", _db.SpeakerEntries);
        }
    }
}