using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WatiN.Core;

namespace ConferenceBooker.Tests.WatiN
{
	[TestClass]
	public class HomeControllerTests
	{
		[TestMethod]
		public void AccessLandingPageTest()
		{
			bool hasText;

			using (IE ie = new IE())
			{

				ie.GoTo("https://localhost:44321/");
				hasText = ie.ContainsText("Welcome To Conference Booker");
			}

			Assert.IsTrue(hasText, @"Welcome To Conference Booker");
		}
	}
}
