using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RAWebServicesMVC
{
    public class ArtistClient
    {
        private static string userId = "2090605";
        private static string apiKey = "a465bde8-ba57-4ce0-95af-923cb856ab9d";
        private string artistId;

        private string artistName;
        private string artistProfileImageURL;
        private string artistProfileURL;

        dj djSvc;

        XmlNode artistNode = null;
        XmlNode artistnameNode = null;
        XmlNode profileimageNode = null;
        XmlNode raprofileNode = null;

        public ArtistClient(string artistId)
        {
            djSvc = new dj();
            this.artistId = artistId;
            initialise();
        }

        public void setArtist(string artistId)
        {
            this.artistId = artistId;
            initialise();
        }

        public void initialise()
        {
            try
            {
                XmlNode root = djSvc.getartist(userId, apiKey, artistId, "", "");

                artistNode = root.FirstChild;
            }
            catch (System.Web.Services.Protocols.SoapException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        public string getArtistName()
        {
            artistnameNode = artistNode.SelectSingleNode("artistname");
            artistName = artistnameNode.InnerText;
            return artistName;
        }
        public string getArtistProfileImageURL()
        {
            profileimageNode = artistNode.SelectSingleNode("profileimage");
            artistProfileImageURL = profileimageNode.InnerText;
            return artistProfileImageURL;
        }
        public string getArtistProfileURL()
        {
            raprofileNode = artistNode.SelectSingleNode("raprofile");
            artistProfileURL = raprofileNode.InnerText;
            return artistProfileURL;
        }
    }
}
