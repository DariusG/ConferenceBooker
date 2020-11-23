using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConferenceBooker.DAL;
using ConferenceBooker.Models;

namespace ConferenceBooker.Controllers
{
    public class ConferenceController : Controller
    {
        IConferenceRepository _conferenceRepository = new ConferenceRepository();
        //EF
        private ConferenceContext _db  = new ConferenceContext();

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
	        //var presentations = _conferenceRepository.GetPresentations();
	        var presentations = _db.PresentationEntries;
            return View(presentations);
        }

        public ActionResult Create()
        {
            var presentation = new Presentation();
	        return View(presentation);
        }

        [HttpPost]
        public ActionResult Create(Presentation presentation)
        {
	        if (ModelState.IsValid)
	        {
		        _db.PresentationEntries.Add(presentation);
                _db.SaveChanges();

                //_conferenceRepository.InsertPresentation(presentation);
                //return View("Index", _conferenceRepository.GetPresentations());
                return View("Index", _db.PresentationEntries);
            }
            return View(presentation);
        }

        public ActionResult Edit(int id)
        {
	        if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));
	        //Presentation presentation = _conferenceRepository.GetPresentationById(id);
	        Presentation presentation = _db.PresentationEntries.Find(id);

            return View(presentation);
        }

        [HttpPost]
        public ActionResult Edit(Presentation presentation)
        {
			if (ModelState.IsValid)
			{
                //_conferenceRepository.UpdatePresentation(presentation);
                _db.PresentationEntries.AddOrUpdate(presentation);
                //return View("Index",_conferenceRepository.GetPresentations()); 
                return View("Index", _db.PresentationEntries);
            }

			return View(presentation);
        }

        public ActionResult Details(int id)
        {
	        if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));
            //Presentation presentation = _conferenceRepository.GetPresentationById(id);
            Presentation presentation = _db.PresentationEntries.Find(id);
            return View(presentation);
        }

        public ActionResult Delete(int id)
        {
	        if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));
            //_conferenceRepository.DeletePresentation(id);
            Presentation presentation = _db.PresentationEntries.Find(id);
            if (presentation != null) _db.PresentationEntries.Remove(presentation);
            //return View("Index", _conferenceRepository.GetPresentations());
            return View("Index", _db.PresentationEntries);
        }
    }
}