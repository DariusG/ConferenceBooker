using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConferenceBooker.DAL;

namespace ConferenceBooker.Controllers
{
    public class ConferenceController : Controller
    {
        IConferenceRepository _conferenceRepository = new ConferenceRepository();

        public ConferenceController(IConferenceRepository repo)
        {
	        _conferenceRepository = repo;
        }

        public ConferenceController()
        {
	        _conferenceRepository = new MockRepository();
        }

        // GET: Conference
        public ActionResult Index()
        {
	        var presentations = _conferenceRepository.GetPresentations();
            return View(presentations);
        }
    }
}