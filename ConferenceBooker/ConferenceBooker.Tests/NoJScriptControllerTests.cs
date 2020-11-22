using System;
using System.Web.Mvc;
using ConferenceBooker.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConferenceBooker.Tests
{
	[TestClass]
	public class NoJScriptControllerTests
	{
		[TestMethod]
		public void PageExists()
		{
			NoJScriptController njs = new NoJScriptController();
			Assert.IsNotNull(njs);
		}

		[TestMethod]
		public void TestForRedirectOfPage()
		{
			NoJScriptController njs = new NoJScriptController();
			ActionResult actionResult = njs.ToLogin();
			Assert.IsInstanceOfType(actionResult,typeof(RedirectToRouteResult));
			Assert.IsTrue((actionResult as RedirectToRouteResult).RouteValues.ContainsValue("Home"));
		}
	}
}
