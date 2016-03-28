using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace RAWebServicesMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult displayEvent()
        {
            ViewBag.Message = "Your application description page.";

            string artistId1 = "1014"; // Omar-S
            string artistId2 = "7745"; // Kyle Hall
            string artistId3 = "4561"; // Hunee
            
            ArtistClient ac = new ArtistClient(artistId1);
            Artist artist1 = new Artist(ac.getArtistName(), ac.getArtistProfileImageURL(), ac.getArtistProfileURL());

            ac.setArtist(artistId2);
            Artist artist2 = new Artist(ac.getArtistName(), ac.getArtistProfileImageURL(), ac.getArtistProfileURL());

            ac.setArtist(artistId3);
            Artist artist3 = new Artist(ac.getArtistName(), ac.getArtistProfileImageURL(), ac.getArtistProfileURL());

            List<Artist> artistList = new List<Artist>();
            artistList.Add(artist1);
            artistList.Add(artist2);
            artistList.Add(artist3);
            
            return View(artistList);
        }
    }
}