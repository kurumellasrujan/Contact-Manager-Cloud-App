using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactManager.Controllers;
using System.Web.Mvc;

namespace ContactManager.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void About_Message_Check()
        {
            HomeController controller = new HomeController();
            var ar = controller.About() as ViewResult;
            Assert.AreEqual("Your application description page.", ar.ViewData["Message"]);
        }

        [TestMethod]
        public void Index_Action_Should_Return_Index_View()
        {
            var controller = new HomeController();
            var indexResult = controller.Index() as ViewResult;
            Assert.AreEqual(indexResult.ViewName, "");
        }
    }
}
