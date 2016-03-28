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
    public class ArtistClientTest
    {
        [TestMethod]
        public void ArtistClient()
        {
            // Arrange
            ArtistClient testClient = new ArtistClient("1014");

            // Test data
            string testString = "Omar-S";

            // Assert
            Assert.AreEqual(testClient.getArtistName(), testString);
        }
    }
}