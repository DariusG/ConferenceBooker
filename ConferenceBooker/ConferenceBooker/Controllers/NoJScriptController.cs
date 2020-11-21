using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConferenceBooker.Controllers
{
    public class NoJScriptController : Controller
    {
	    //
	    // GET: /NoJScript/
	    [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ToLogin()
        {
	        return RedirectToAction("Index", "Home");
        }
    }
}