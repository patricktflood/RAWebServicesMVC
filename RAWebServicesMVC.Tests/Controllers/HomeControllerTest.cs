using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RAWebServicesMVC;
using RAWebServicesMVC.Controllers;

namespace RAWebServicesMVC.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void displayEvent()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.displayEvent() as ViewResult;
            List<Artist> artistListTest = (List<Artist>)result.ViewData.Model;

            // Test data
            List<Artist> testData = new List<Artist>();
            testData.Add(new Artist("", "", ""));
            testData.Add(new Artist("", "", ""));
            testData.Add(new Artist("", "", ""));

            // Assert
            Assert.AreEqual(testData.Count, artistListTest.Count);
        }
    }
}
