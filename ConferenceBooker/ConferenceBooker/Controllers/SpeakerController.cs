using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConferenceBooker.DAL;

namespace ConferenceBooker.Controllers
{
    public class SpeakerController : Controller
    {
	    IConferenceRepository _conferenceRepository = new ConferenceRepository();

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
			var speakers = _conferenceRepository.GetSpeakers();
            return View(speakers);
        }

        public ActionResult Create()
        {
	        throw new NotImplementedException();
        }

        public ActionResult Edit(int id)
        {
	        throw new NotImplementedException();
        }

        public ActionResult Details(int id)
        {
	        throw new NotImplementedException();
        }

        public ActionResult Delete(int id)
        {
	        throw new NotImplementedException();
        }
    }
}